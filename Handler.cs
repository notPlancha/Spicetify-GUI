using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.ObjectModel;

namespace SpicetifyGUI; 

static public class Handler {
    static readonly List<Runspace> Runspaces = new();
    static string _spicetifyFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)  + @"\spicetify"; //TODO change this to right folder
    #region HandlerHelpers
    [AllowNull]
    static HttpClient _client;
    static HttpClient Client {
        get {
            if (_client is null) {
                _client = new();
                _client.DefaultRequestHeaders.Add("User-Agent", "request");
            }
            return _client;
        }
    }
    static class Commands {
        public const string
            InstallMarketplace =
                @"iwr -useb https://raw.githubusercontent.com/spicetify/spicetify-marketplace/main/resources/install.ps1 | iex", //TODO remove
            CheckInstall = @"spicetify -v",
            SelfUpdate = @"", //TODO
            Empty = @""; //to facilitate writing commas
    }
    static Collection<PSObject> ExecuteCommand(string command) {//TODO return smth
        using Runspace runspace = RunspaceFactory.CreateRunspace();
        Runspaces.Add(runspace);

        runspace.Open();
        Pipeline pipeline = runspace.CreatePipeline();
        pipeline.Commands.AddScript(command);
        Collection<PSObject> results = pipeline.Invoke();
        runspace.Close();
        Runspaces.Remove(runspace);
        return results;
    }
    static async Task<Collection<PSObject>> ExecuteCommandAsync(string command) => await Task.Run(() => ExecuteCommand(command));
    static async Task<object> WebGetAsync(string url) {
        HttpResponseMessage response = await Client.GetAsync(url);
        response.EnsureSuccessStatusCode();
        using StreamReader streamReader = new StreamReader(await response.Content.ReadAsStreamAsync());
        using JsonTextReader jsonReader = new JsonTextReader(streamReader);
        return new JsonSerializer().Deserialize(jsonReader);
        
    }
    static bool AddToPath(string path, bool machine = false) {
        EnvironmentVariableTarget scope = machine ? EnvironmentVariableTarget.Machine : EnvironmentVariableTarget.User;
        string oldValue = Environment.GetEnvironmentVariable("PATH");
        if (oldValue?.Contains(path) ?? false) return false;
        Environment.SetEnvironmentVariable("PATH", oldValue + ";" + path);
        return true;
    }
    #endregion
    
    static public bool needsInstall() {
#if DEBUG
        ExecuteCommand(Commands.CheckInstall);
        return true;
#endif
        throw new NotImplementedException();
    }
    static public async Task InstallSpcietifyAsync() {
        #region determine url and paths
        JObject values = await WebGetAsync(@"https://api.github.com/repos/spicetify/spicetify-cli/releases/latest") as JObject;
        if (values?.ContainsKey("message") ?? true) throw new DirectoryNotFoundException("repo not found");
        bool isX64 = Environment.Is64BitOperatingSystem;
        JObject file = (JObject)values["assets"]!.First(v => ((string)v["name"])!.Contains("windows-" + (isX64 ? "x64" : "x32")));
        string fileUrl = (string)file["browser_download_url"];
        string fileName = (string)file["name"];
        string filePath = _spicetifyFolder + "\\" + fileName;
        #endregion
        #region create path
        if (!Directory.Exists(_spicetifyFolder)) Directory.CreateDirectory(_spicetifyFolder);
        #endregion
        using (WebClient client = new WebClient()) {
            //TODO change to dynamic 
            await client.DownloadFileTaskAsync(fileUrl!, filePath);
        }
        System.IO.Compression.ZipFile.ExtractToDirectory(filePath, _spicetifyFolder, true);
        
        AddToPath(_spicetifyFolder, machine: false);
    }
}
