﻿namespace PlantUmlViewer.Forms
{
    partial class PreviewWindow
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel_Window = new System.Windows.Forms.TableLayoutPanel();
            this.statusStrip_Bottom = new System.Windows.Forms.StatusStrip();
            this.loadingCircleToolStripMenuItem_Refreshing = new MRG.Controls.UI.LoadingCircleToolStripMenuItem();
            this.toolStripStatusLabel_Time = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_Zoom = new System.Windows.Forms.ToolStripStatusLabel();
            this.imageBox_Diagram = new Cyotek.Windows.Forms.ImageBox();
            this.contextMenuStrip_Diagram = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_Diagram_CopyToClipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Diagram_ExportFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel_Buttons = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_NavigationPage = new System.Windows.Forms.TableLayoutPanel();
            this.button_PreviousPage = new System.Windows.Forms.Button();
            this.button_NextPage = new System.Windows.Forms.Button();
            this.label_SelectedPage = new System.Windows.Forms.Label();
            this.button_ZoomReset = new System.Windows.Forms.Button();
            this.button_ZoomFit = new System.Windows.Forms.Button();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.button_ZoomIn = new System.Windows.Forms.Button();
            this.button_Export = new System.Windows.Forms.Button();
            this.button_ZoomOut = new System.Windows.Forms.Button();
            this.tableLayoutPanel_NavigationDiagram = new System.Windows.Forms.TableLayoutPanel();
            this.button_PreviousDiagram = new System.Windows.Forms.Button();
            this.button_NextDiagram = new System.Windows.Forms.Button();
            this.label_SelectedDiagram = new System.Windows.Forms.Label();
            this.toolTip_Buttons = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel_Window.SuspendLayout();
            this.statusStrip_Bottom.SuspendLayout();
            this.contextMenuStrip_Diagram.SuspendLayout();
            this.tableLayoutPanel_Buttons.SuspendLayout();
            this.tableLayoutPanel_NavigationPage.SuspendLayout();
            this.tableLayoutPanel_NavigationDiagram.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_Window
            // 
            this.tableLayoutPanel_Window.ColumnCount = 1;
            this.tableLayoutPanel_Window.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Window.Controls.Add(this.statusStrip_Bottom, 0, 2);
            this.tableLayoutPanel_Window.Controls.Add(this.imageBox_Diagram, 0, 1);
            this.tableLayoutPanel_Window.Controls.Add(this.tableLayoutPanel_Buttons, 0, 0);
            this.tableLayoutPanel_Window.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Window.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Window.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel_Window.Name = "tableLayoutPanel_Window";
            this.tableLayoutPanel_Window.RowCount = 3;
            this.tableLayoutPanel_Window.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel_Window.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Window.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel_Window.Size = new System.Drawing.Size(384, 261);
            this.tableLayoutPanel_Window.TabIndex = 0;
            this.tableLayoutPanel_Window.TabStop = true;
            // 
            // statusStrip_Bottom
            // 
            this.statusStrip_Bottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusStrip_Bottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadingCircleToolStripMenuItem_Refreshing,
            this.toolStripStatusLabel_Time,
            this.toolStripStatusLabel_Zoom});
            this.statusStrip_Bottom.Location = new System.Drawing.Point(0, 239);
            this.statusStrip_Bottom.Name = "statusStrip_Bottom";
            this.statusStrip_Bottom.Size = new System.Drawing.Size(384, 22);
            this.statusStrip_Bottom.TabIndex = 2;
            // 
            // loadingCircleToolStripMenuItem_Refreshing
            // 
            // 
            // loadingCircleToolStripMenuItem_Refreshing
            // 
            this.loadingCircleToolStripMenuItem_Refreshing.LoadingCircleControl.AccessibleName = "loadingCircleToolStripMenuItem_Refreshing";
            this.loadingCircleToolStripMenuItem_Refreshing.LoadingCircleControl.Active = false;
            this.loadingCircleToolStripMenuItem_Refreshing.LoadingCircleControl.Color = System.Drawing.Color.DarkGray;
            this.loadingCircleToolStripMenuItem_Refreshing.LoadingCircleControl.InnerCircleRadius = 6;
            this.loadingCircleToolStripMenuItem_Refreshing.LoadingCircleControl.Location = new System.Drawing.Point(0, 0);
            this.loadingCircleToolStripMenuItem_Refreshing.LoadingCircleControl.Name = "loadingCircleToolStripMenuItem_Refreshing";
            this.loadingCircleToolStripMenuItem_Refreshing.LoadingCircleControl.NumberSpoke = 9;
            this.loadingCircleToolStripMenuItem_Refreshing.LoadingCircleControl.OuterCircleRadius = 7;
            this.loadingCircleToolStripMenuItem_Refreshing.LoadingCircleControl.RotationSpeed = 100;
            this.loadingCircleToolStripMenuItem_Refreshing.LoadingCircleControl.Size = new System.Drawing.Size(22, 20);
            this.loadingCircleToolStripMenuItem_Refreshing.LoadingCircleControl.SpokeThickness = 4;
            this.loadingCircleToolStripMenuItem_Refreshing.LoadingCircleControl.StylePreset = MRG.Controls.UI.LoadingCircle.StylePresets.Firefox;
            this.loadingCircleToolStripMenuItem_Refreshing.LoadingCircleControl.TabIndex = 1;
            this.loadingCircleToolStripMenuItem_Refreshing.LoadingCircleControl.Text = "Refreshing";
            this.loadingCircleToolStripMenuItem_Refreshing.LoadingCircleControl.Visible = false;
            this.loadingCircleToolStripMenuItem_Refreshing.Name = "loadingCircleToolStripMenuItem_Refreshing";
            this.loadingCircleToolStripMenuItem_Refreshing.Size = new System.Drawing.Size(22, 20);
            this.loadingCircleToolStripMenuItem_Refreshing.Text = "Refreshing";
            this.loadingCircleToolStripMenuItem_Refreshing.Visible = false;
            // 
            // toolStripStatusLabel_Time
            // 
            this.toolStripStatusLabel_Time.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.toolStripStatusLabel_Time.Name = "toolStripStatusLabel_Time";
            this.toolStripStatusLabel_Time.Size = new System.Drawing.Size(334, 16);
            this.toolStripStatusLabel_Time.Spring = true;
            // 
            // toolStripStatusLabel_Zoom
            // 
            this.toolStripStatusLabel_Zoom.Name = "toolStripStatusLabel_Zoom";
            this.toolStripStatusLabel_Zoom.Size = new System.Drawing.Size(35, 17);
            this.toolStripStatusLabel_Zoom.Text = "100%";
            // 
            // imageBox_Diagram
            // 
            this.imageBox_Diagram.ContextMenuStrip = this.contextMenuStrip_Diagram;
            this.imageBox_Diagram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox_Diagram.GridDisplayMode = Cyotek.Windows.Forms.ImageBoxGridDisplayMode.None;
            this.imageBox_Diagram.Location = new System.Drawing.Point(0, 38);
            this.imageBox_Diagram.Margin = new System.Windows.Forms.Padding(0);
            this.imageBox_Diagram.MouseWheelMode = Cyotek.Windows.Forms.ImageBoxMouseWheelMode.ScrollAndZoom;
            this.imageBox_Diagram.Name = "imageBox_Diagram";
            this.imageBox_Diagram.Size = new System.Drawing.Size(384, 201);
            this.imageBox_Diagram.TabIndex = 1;
            this.imageBox_Diagram.TabStop = false;
            // 
            // contextMenuStrip_Diagram
            // 
            this.contextMenuStrip_Diagram.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Diagram_CopyToClipboard,
            this.ToolStripMenuItem_Diagram_ExportFile});
            this.contextMenuStrip_Diagram.Name = "contextMenuStrip_Diagram";
            this.contextMenuStrip_Diagram.Size = new System.Drawing.Size(170, 48);
            // 
            // ToolStripMenuItem_Diagram_CopyToClipboard
            // 
            this.ToolStripMenuItem_Diagram_CopyToClipboard.Enabled = false;
            this.ToolStripMenuItem_Diagram_CopyToClipboard.Name = "ToolStripMenuItem_Diagram_CopyToClipboard";
            this.ToolStripMenuItem_Diagram_CopyToClipboard.Size = new System.Drawing.Size(169, 22);
            this.ToolStripMenuItem_Diagram_CopyToClipboard.Text = "Copy to clipboard";
            this.ToolStripMenuItem_Diagram_CopyToClipboard.Click += new System.EventHandler(this.ToolStripMenuItem_Diagram_CopyToClipboard_Click);
            // 
            // ToolStripMenuItem_Diagram_ExportFile
            // 
            this.ToolStripMenuItem_Diagram_ExportFile.Enabled = false;
            this.ToolStripMenuItem_Diagram_ExportFile.Name = "ToolStripMenuItem_Diagram_ExportFile";
            this.ToolStripMenuItem_Diagram_ExportFile.Size = new System.Drawing.Size(169, 22);
            this.ToolStripMenuItem_Diagram_ExportFile.Text = "Export";
            this.ToolStripMenuItem_Diagram_ExportFile.Click += new System.EventHandler(this.Button_Export_Click);
            // 
            // tableLayoutPanel_Buttons
            // 
            this.tableLayoutPanel_Buttons.ColumnCount = 8;
            this.tableLayoutPanel_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_Buttons.Controls.Add(this.tableLayoutPanel_NavigationPage, 7, 0);
            this.tableLayoutPanel_Buttons.Controls.Add(this.button_ZoomReset, 5, 0);
            this.tableLayoutPanel_Buttons.Controls.Add(this.button_ZoomFit, 4, 0);
            this.tableLayoutPanel_Buttons.Controls.Add(this.button_Refresh, 0, 0);
            this.tableLayoutPanel_Buttons.Controls.Add(this.button_ZoomIn, 2, 0);
            this.tableLayoutPanel_Buttons.Controls.Add(this.button_Export, 1, 0);
            this.tableLayoutPanel_Buttons.Controls.Add(this.button_ZoomOut, 3, 0);
            this.tableLayoutPanel_Buttons.Controls.Add(this.tableLayoutPanel_NavigationDiagram, 6, 0);
            this.tableLayoutPanel_Buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Buttons.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_Buttons.Name = "tableLayoutPanel_Buttons";
            this.tableLayoutPanel_Buttons.RowCount = 1;
            this.tableLayoutPanel_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Buttons.Size = new System.Drawing.Size(378, 32);
            this.tableLayoutPanel_Buttons.TabIndex = 0;
            this.tableLayoutPanel_Buttons.TabStop = true;
            // 
            // tableLayoutPanel_NavigationPage
            // 
            this.tableLayoutPanel_NavigationPage.ColumnCount = 3;
            this.tableLayoutPanel_NavigationPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_NavigationPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_NavigationPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_NavigationPage.Controls.Add(this.button_PreviousPage, 0, 0);
            this.tableLayoutPanel_NavigationPage.Controls.Add(this.button_NextPage, 2, 0);
            this.tableLayoutPanel_NavigationPage.Controls.Add(this.label_SelectedPage, 1, 0);
            this.tableLayoutPanel_NavigationPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_NavigationPage.Location = new System.Drawing.Point(276, 0);
            this.tableLayoutPanel_NavigationPage.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel_NavigationPage.Name = "tableLayoutPanel_NavigationPage";
            this.tableLayoutPanel_NavigationPage.RowCount = 1;
            this.tableLayoutPanel_NavigationPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_NavigationPage.Size = new System.Drawing.Size(102, 32);
            this.tableLayoutPanel_NavigationPage.TabIndex = 10;
            this.tableLayoutPanel_NavigationPage.Visible = false;
            // 
            // button_PreviousPage
            // 
            this.button_PreviousPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_PreviousPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_PreviousPage.Enabled = false;
            this.button_PreviousPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_PreviousPage.Location = new System.Drawing.Point(3, 3);
            this.button_PreviousPage.Name = "button_PreviousPage";
            this.button_PreviousPage.Size = new System.Drawing.Size(42, 26);
            this.button_PreviousPage.TabIndex = 11;
            this.button_PreviousPage.UseVisualStyleBackColor = true;
            this.button_PreviousPage.EnabledChanged += new System.EventHandler(this.Button_EnabledChanged);
            this.button_PreviousPage.Click += new System.EventHandler(this.Button_PreviousPage_Click);
            // 
            // button_NextPage
            // 
            this.button_NextPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_NextPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_NextPage.Enabled = false;
            this.button_NextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_NextPage.Location = new System.Drawing.Point(57, 3);
            this.button_NextPage.Name = "button_NextPage";
            this.button_NextPage.Size = new System.Drawing.Size(42, 26);
            this.button_NextPage.TabIndex = 12;
            this.button_NextPage.UseVisualStyleBackColor = true;
            this.button_NextPage.EnabledChanged += new System.EventHandler(this.Button_EnabledChanged);
            this.button_NextPage.Click += new System.EventHandler(this.Button_NextPage_Click);
            // 
            // label_SelectedPage
            // 
            this.label_SelectedPage.AutoSize = true;
            this.label_SelectedPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_SelectedPage.Location = new System.Drawing.Point(51, 0);
            this.label_SelectedPage.Name = "label_SelectedPage";
            this.label_SelectedPage.Size = new System.Drawing.Size(1, 32);
            this.label_SelectedPage.TabIndex = 7;
            this.label_SelectedPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_ZoomReset
            // 
            this.button_ZoomReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_ZoomReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_ZoomReset.Enabled = false;
            this.button_ZoomReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ZoomReset.Location = new System.Drawing.Point(148, 3);
            this.button_ZoomReset.Name = "button_ZoomReset";
            this.button_ZoomReset.Size = new System.Drawing.Size(23, 26);
            this.button_ZoomReset.TabIndex = 6;
            this.button_ZoomReset.UseVisualStyleBackColor = true;
            this.button_ZoomReset.EnabledChanged += new System.EventHandler(this.Button_EnabledChanged);
            this.button_ZoomReset.Click += new System.EventHandler(this.Button_ZoomReset_Click);
            // 
            // button_ZoomFit
            // 
            this.button_ZoomFit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_ZoomFit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_ZoomFit.Enabled = false;
            this.button_ZoomFit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ZoomFit.Location = new System.Drawing.Point(119, 3);
            this.button_ZoomFit.Name = "button_ZoomFit";
            this.button_ZoomFit.Size = new System.Drawing.Size(23, 26);
            this.button_ZoomFit.TabIndex = 5;
            this.button_ZoomFit.UseVisualStyleBackColor = true;
            this.button_ZoomFit.EnabledChanged += new System.EventHandler(this.Button_EnabledChanged);
            this.button_ZoomFit.Click += new System.EventHandler(this.Button_ZoomFit_Click);
            // 
            // button_Refresh
            // 
            this.button_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Refresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Refresh.Location = new System.Drawing.Point(3, 3);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(23, 26);
            this.button_Refresh.TabIndex = 1;
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.EnabledChanged += new System.EventHandler(this.Button_EnabledChanged);
            this.button_Refresh.Click += new System.EventHandler(this.Button_Refresh_Click);
            // 
            // button_ZoomIn
            // 
            this.button_ZoomIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_ZoomIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_ZoomIn.Enabled = false;
            this.button_ZoomIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ZoomIn.Location = new System.Drawing.Point(61, 3);
            this.button_ZoomIn.Name = "button_ZoomIn";
            this.button_ZoomIn.Size = new System.Drawing.Size(23, 26);
            this.button_ZoomIn.TabIndex = 3;
            this.button_ZoomIn.UseVisualStyleBackColor = true;
            this.button_ZoomIn.EnabledChanged += new System.EventHandler(this.Button_EnabledChanged);
            this.button_ZoomIn.Click += new System.EventHandler(this.Button_ZoomIn_Click);
            // 
            // button_Export
            // 
            this.button_Export.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Export.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Export.Enabled = false;
            this.button_Export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Export.Location = new System.Drawing.Point(32, 3);
            this.button_Export.Name = "button_Export";
            this.button_Export.Size = new System.Drawing.Size(23, 26);
            this.button_Export.TabIndex = 2;
            this.button_Export.UseVisualStyleBackColor = true;
            this.button_Export.EnabledChanged += new System.EventHandler(this.Button_EnabledChanged);
            this.button_Export.Click += new System.EventHandler(this.Button_Export_Click);
            // 
            // button_ZoomOut
            // 
            this.button_ZoomOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_ZoomOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_ZoomOut.Enabled = false;
            this.button_ZoomOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ZoomOut.Location = new System.Drawing.Point(90, 3);
            this.button_ZoomOut.Name = "button_ZoomOut";
            this.button_ZoomOut.Size = new System.Drawing.Size(23, 26);
            this.button_ZoomOut.TabIndex = 4;
            this.button_ZoomOut.UseVisualStyleBackColor = true;
            this.button_ZoomOut.EnabledChanged += new System.EventHandler(this.Button_EnabledChanged);
            this.button_ZoomOut.Click += new System.EventHandler(this.Button_ZoomOut_Click);
            // 
            // tableLayoutPanel_NavigationDiagram
            // 
            this.tableLayoutPanel_NavigationDiagram.ColumnCount = 3;
            this.tableLayoutPanel_NavigationDiagram.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_NavigationDiagram.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_NavigationDiagram.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_NavigationDiagram.Controls.Add(this.button_PreviousDiagram, 0, 0);
            this.tableLayoutPanel_NavigationDiagram.Controls.Add(this.button_NextDiagram, 2, 0);
            this.tableLayoutPanel_NavigationDiagram.Controls.Add(this.label_SelectedDiagram, 1, 0);
            this.tableLayoutPanel_NavigationDiagram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_NavigationDiagram.Location = new System.Drawing.Point(174, 0);
            this.tableLayoutPanel_NavigationDiagram.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel_NavigationDiagram.Name = "tableLayoutPanel_NavigationDiagram";
            this.tableLayoutPanel_NavigationDiagram.RowCount = 1;
            this.tableLayoutPanel_NavigationDiagram.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_NavigationDiagram.Size = new System.Drawing.Size(102, 32);
            this.tableLayoutPanel_NavigationDiagram.TabIndex = 7;
            this.tableLayoutPanel_NavigationDiagram.Visible = false;
            // 
            // button_PreviousDiagram
            // 
            this.button_PreviousDiagram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_PreviousDiagram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_PreviousDiagram.Enabled = false;
            this.button_PreviousDiagram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_PreviousDiagram.Location = new System.Drawing.Point(3, 3);
            this.button_PreviousDiagram.Name = "button_PreviousDiagram";
            this.button_PreviousDiagram.Size = new System.Drawing.Size(42, 26);
            this.button_PreviousDiagram.TabIndex = 8;
            this.button_PreviousDiagram.UseVisualStyleBackColor = true;
            this.button_PreviousDiagram.EnabledChanged += new System.EventHandler(this.Button_EnabledChanged);
            this.button_PreviousDiagram.Click += new System.EventHandler(this.Button_PreviousDiagram_Click);
            // 
            // button_NextDiagram
            // 
            this.button_NextDiagram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_NextDiagram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_NextDiagram.Enabled = false;
            this.button_NextDiagram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_NextDiagram.Location = new System.Drawing.Point(57, 3);
            this.button_NextDiagram.Name = "button_NextDiagram";
            this.button_NextDiagram.Size = new System.Drawing.Size(42, 26);
            this.button_NextDiagram.TabIndex = 9;
            this.button_NextDiagram.UseVisualStyleBackColor = true;
            this.button_NextDiagram.EnabledChanged += new System.EventHandler(this.Button_EnabledChanged);
            this.button_NextDiagram.Click += new System.EventHandler(this.Button_NextDiagram_Click);
            // 
            // label_SelectedDiagram
            // 
            this.label_SelectedDiagram.AutoSize = true;
            this.label_SelectedDiagram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_SelectedDiagram.Location = new System.Drawing.Point(51, 0);
            this.label_SelectedDiagram.Name = "label_SelectedDiagram";
            this.label_SelectedDiagram.Size = new System.Drawing.Size(1, 32);
            this.label_SelectedDiagram.TabIndex = 7;
            this.label_SelectedDiagram.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PreviewWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.tableLayoutPanel_Window);
            this.Name = "PreviewWindow";
            this.Text = "PlantUML";
            this.tableLayoutPanel_Window.ResumeLayout(false);
            this.tableLayoutPanel_Window.PerformLayout();
            this.statusStrip_Bottom.ResumeLayout(false);
            this.statusStrip_Bottom.PerformLayout();
            this.contextMenuStrip_Diagram.ResumeLayout(false);
            this.tableLayoutPanel_Buttons.ResumeLayout(false);
            this.tableLayoutPanel_NavigationPage.ResumeLayout(false);
            this.tableLayoutPanel_NavigationPage.PerformLayout();
            this.tableLayoutPanel_NavigationDiagram.ResumeLayout(false);
            this.tableLayoutPanel_NavigationDiagram.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Window;
        private System.Windows.Forms.Button button_Refresh;
        private Cyotek.Windows.Forms.ImageBox imageBox_Diagram;
        private System.Windows.Forms.Button button_Export;
        private System.Windows.Forms.StatusStrip statusStrip_Bottom;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Zoom;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Time;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Diagram;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Diagram_CopyToClipboard;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Diagram_ExportFile;
        private MRG.Controls.UI.LoadingCircleToolStripMenuItem loadingCircleToolStripMenuItem_Refreshing;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Buttons;
        private System.Windows.Forms.Button button_NextDiagram;
        private System.Windows.Forms.Button button_ZoomIn;
        private System.Windows.Forms.Button button_PreviousDiagram;
        private System.Windows.Forms.Button button_ZoomOut;
        private System.Windows.Forms.Label label_SelectedDiagram;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_NavigationDiagram;
        private System.Windows.Forms.ToolTip toolTip_Buttons;
        private System.Windows.Forms.Button button_ZoomFit;
        private System.Windows.Forms.Button button_ZoomReset;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_NavigationPage;
        private System.Windows.Forms.Button button_PreviousPage;
        private System.Windows.Forms.Button button_NextPage;
        private System.Windows.Forms.Label label_SelectedPage;
    }
}