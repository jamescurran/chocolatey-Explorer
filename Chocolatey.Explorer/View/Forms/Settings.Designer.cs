﻿namespace Chocolatey.Explorer.View.Forms
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblLib = new System.Windows.Forms.Label();
            this.txtInstallDirectory = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnClearInstalledPackagesCache = new System.Windows.Forms.Button();
            this.btnClearAvailablePackagesCache = new System.Windows.Forms.Button();
            this.btnClearCacheAll = new System.Windows.Forms.Button();
            this.btnClearPackageVersionCache = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstSources = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkHasODataFeed = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblLib);
            this.tabPage1.Controls.Add(this.txtInstallDirectory);
            this.tabPage1.Controls.Add(this.btnBrowse);
            this.tabPage1.Controls.Add(this.btnSave);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblLib
            // 
            resources.ApplyResources(this.lblLib, "lblLib");
            this.lblLib.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.lblLib.Name = "lblLib";
            // 
            // txtInstallDirectory
            // 
            resources.ApplyResources(this.txtInstallDirectory, "txtInstallDirectory");
            this.txtInstallDirectory.Name = "txtInstallDirectory";
            // 
            // btnBrowse
            // 
            resources.ApplyResources(this.btnBrowse, "btnBrowse");
            this.btnBrowse.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBrowse.Image = global::Chocolatey.Explorer.Properties.Resources.folder_small;
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnClearInstalledPackagesCache);
            this.tabPage2.Controls.Add(this.btnClearAvailablePackagesCache);
            this.tabPage2.Controls.Add(this.btnClearCacheAll);
            this.tabPage2.Controls.Add(this.btnClearPackageVersionCache);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnClearInstalledPackagesCache
            // 
            resources.ApplyResources(this.btnClearInstalledPackagesCache, "btnClearInstalledPackagesCache");
            this.btnClearInstalledPackagesCache.Name = "btnClearInstalledPackagesCache";
            this.btnClearInstalledPackagesCache.UseVisualStyleBackColor = true;
            this.btnClearInstalledPackagesCache.Click += new System.EventHandler(this.btnClearInstalledPackagesCache_Click);
            // 
            // btnClearAvailablePackagesCache
            // 
            resources.ApplyResources(this.btnClearAvailablePackagesCache, "btnClearAvailablePackagesCache");
            this.btnClearAvailablePackagesCache.Name = "btnClearAvailablePackagesCache";
            this.btnClearAvailablePackagesCache.UseVisualStyleBackColor = true;
            this.btnClearAvailablePackagesCache.Click += new System.EventHandler(this.btnClearAvailablePackagesCache_Click);
            // 
            // btnClearCacheAll
            // 
            resources.ApplyResources(this.btnClearCacheAll, "btnClearCacheAll");
            this.btnClearCacheAll.Name = "btnClearCacheAll";
            this.btnClearCacheAll.UseVisualStyleBackColor = true;
            this.btnClearCacheAll.Click += new System.EventHandler(this.btnClearCacheAll_Click);
            // 
            // btnClearPackageVersionCache
            // 
            resources.ApplyResources(this.btnClearPackageVersionCache, "btnClearPackageVersionCache");
            this.btnClearPackageVersionCache.Name = "btnClearPackageVersionCache";
            this.btnClearPackageVersionCache.UseVisualStyleBackColor = true;
            this.btnClearPackageVersionCache.Click += new System.EventHandler(this.btnClearPackageVersionCache_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chkHasODataFeed);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.txtSource);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.lstSources);
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtSource
            // 
            resources.ApplyResources(this.txtSource, "txtSource");
            this.txtSource.Name = "txtSource";
            this.txtSource.ReadOnly = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lstSources
            // 
            resources.ApplyResources(this.lstSources, "lstSources");
            this.lstSources.FormattingEnabled = true;
            this.lstSources.Name = "lstSources";
            this.lstSources.SelectedIndexChanged += new System.EventHandler(this.lstSources_SelectedIndexChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // chkHasODataFeed
            // 
            resources.ApplyResources(this.chkHasODataFeed, "chkHasODataFeed");
            this.chkHasODataFeed.Name = "chkHasODataFeed";
            this.chkHasODataFeed.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            resources.ApplyResources(this, "$this");
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblLib;
        private System.Windows.Forms.TextBox txtInstallDirectory;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnClearInstalledPackagesCache;
        private System.Windows.Forms.Button btnClearAvailablePackagesCache;
        private System.Windows.Forms.Button btnClearCacheAll;
        private System.Windows.Forms.Button btnClearPackageVersionCache;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstSources;
        private System.Windows.Forms.CheckBox chkHasODataFeed;
        private System.Windows.Forms.Label label3;

    }
}