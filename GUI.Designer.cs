namespace SpcicetifyGUI; 

partial class Gui {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        this.TabsControl = new System.Windows.Forms.TabControl();
        this.InstallationTab = new System.Windows.Forms.TabPage();
        this.ThemesTab = new System.Windows.Forms.TabPage();
        this.AppsTab = new System.Windows.Forms.TabPage();
        this.ExtensionsTab = new System.Windows.Forms.TabPage();
        this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
        this.containerControl1 = new System.Windows.Forms.ContainerControl();
        this.TabsControl.SuspendLayout();
        this.ThemesTab.SuspendLayout();
        this.SuspendLayout();
        // 
        // TabsControl
        // 
        this.TabsControl.Controls.Add(this.InstallationTab);
        this.TabsControl.Controls.Add(this.ThemesTab);
        this.TabsControl.Controls.Add(this.ExtensionsTab);
        this.TabsControl.Controls.Add(this.AppsTab);
        this.TabsControl.Location = new System.Drawing.Point(4, 2);
        this.TabsControl.Name = "TabsControl";
        this.TabsControl.SelectedIndex = 0;
        this.TabsControl.Size = new System.Drawing.Size(1074, 727);
        this.TabsControl.TabIndex = 0;
        // 
        // InstallationTab
        // 
        this.InstallationTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(56)))), ((int)(((byte)(63)))));
        this.InstallationTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
        this.InstallationTab.Location = new System.Drawing.Point(4, 29);
        this.InstallationTab.Name = "InstallationTab";
        this.InstallationTab.Padding = new System.Windows.Forms.Padding(3);
        this.InstallationTab.Size = new System.Drawing.Size(1066, 694);
        this.InstallationTab.TabIndex = 0;
        this.InstallationTab.Text = "Install";
        // 
        // ThemesTab
        // 
        this.ThemesTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(56)))), ((int)(((byte)(63)))));
        this.ThemesTab.Controls.Add(this.containerControl1);
        this.ThemesTab.Controls.Add(this.checkedListBox1);
        this.ThemesTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
        this.ThemesTab.Location = new System.Drawing.Point(4, 29);
        this.ThemesTab.Name = "ThemesTab";
        this.ThemesTab.Padding = new System.Windows.Forms.Padding(3);
        this.ThemesTab.Size = new System.Drawing.Size(1066, 694);
        this.ThemesTab.TabIndex = 1;
        this.ThemesTab.Text = "Themes";
        // 
        // AppsTab
        // 
        this.AppsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(56)))), ((int)(((byte)(63)))));
        this.AppsTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
        this.AppsTab.Location = new System.Drawing.Point(4, 29);
        this.AppsTab.Name = "AppsTab";
        this.AppsTab.Size = new System.Drawing.Size(1066, 694);
        this.AppsTab.TabIndex = 2;
        this.AppsTab.Text = "Extensions";
        // 
        // ExtensionsTab
        // 
        this.ExtensionsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(56)))), ((int)(((byte)(63)))));
        this.ExtensionsTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
        this.ExtensionsTab.Location = new System.Drawing.Point(4, 29);
        this.ExtensionsTab.Name = "ExtensionsTab";
        this.ExtensionsTab.Size = new System.Drawing.Size(1066, 694);
        this.ExtensionsTab.TabIndex = 3;
        this.ExtensionsTab.Text = "Apps";
        // 
        // checkedListBox1
        // 
        this.checkedListBox1.FormattingEnabled = true;
        this.checkedListBox1.Location = new System.Drawing.Point(18, 19);
        this.checkedListBox1.Name = "checkedListBox1";
        this.checkedListBox1.Size = new System.Drawing.Size(239, 655);
        this.checkedListBox1.TabIndex = 0;
        // 
        // containerControl1
        // 
        this.containerControl1.Location = new System.Drawing.Point(263, 19);
        this.containerControl1.Name = "containerControl1";
        this.containerControl1.Size = new System.Drawing.Size(631, 655);
        this.containerControl1.TabIndex = 1;
        this.containerControl1.Text = "containerControl1";
        // 
        // Gui
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(56)))), ((int)(((byte)(63)))));
        this.ClientSize = new System.Drawing.Size(1084, 736);
        this.Controls.Add(this.TabsControl);
        this.Name = "Gui";
        this.Text = "Form1";
        this.Load += new System.EventHandler(this.Gui_Load);
        this.TabsControl.ResumeLayout(false);
        this.ThemesTab.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.ContainerControl containerControl1;

    private System.Windows.Forms.CheckedListBox checkedListBox1;

    private System.Windows.Forms.TabPage AppsTab;

    private System.Windows.Forms.TabPage ExtensionsTab;

    private System.Windows.Forms.TabControl TabsControl;

    private System.Windows.Forms.TabPage InstallationTab;

    private System.Windows.Forms.TabPage ThemesTab;

    #endregion
}