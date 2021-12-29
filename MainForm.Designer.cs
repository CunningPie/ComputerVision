namespace ComputerVision
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Main_status = new System.Windows.Forms.StatusStrip();
            this.Main_Toolbox_OpenFile = new System.Windows.Forms.ToolStripButton();
            this.Main_Toolbox_SaveFile = new System.Windows.Forms.ToolStripButton();
            this.Main_Toolbox = new System.Windows.Forms.ToolStrip();
            this.Main_LayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Main_SourcePicture = new System.Windows.Forms.PictureBox();
            this.Main_ResultPicture = new System.Windows.Forms.PictureBox();
            this.Main_ContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adjustBrightnesscontrastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateImage45DegreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reflectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binarizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binarizeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cannyEdgesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laplasianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dilateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Main_Toolbox.SuspendLayout();
            this.Main_LayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Main_SourcePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Main_ResultPicture)).BeginInit();
            this.Main_ContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_status
            // 
            this.Main_status.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Main_status.Location = new System.Drawing.Point(0, 486);
            this.Main_status.Name = "Main_status";
            this.Main_status.Size = new System.Drawing.Size(891, 22);
            this.Main_status.TabIndex = 2;
            this.Main_status.Text = "statusStrip1";
            // 
            // Main_Toolbox_OpenFile
            // 
            this.Main_Toolbox_OpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Main_Toolbox_OpenFile.Image = ((System.Drawing.Image)(resources.GetObject("Main_Toolbox_OpenFile.Image")));
            this.Main_Toolbox_OpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Main_Toolbox_OpenFile.Name = "Main_Toolbox_OpenFile";
            this.Main_Toolbox_OpenFile.Size = new System.Drawing.Size(29, 24);
            this.Main_Toolbox_OpenFile.Text = "Open file";
            this.Main_Toolbox_OpenFile.Click += new System.EventHandler(this.Main_Toolbox_OpenFile_Click);
            // 
            // Main_Toolbox_SaveFile
            // 
            this.Main_Toolbox_SaveFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Main_Toolbox_SaveFile.Image = ((System.Drawing.Image)(resources.GetObject("Main_Toolbox_SaveFile.Image")));
            this.Main_Toolbox_SaveFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Main_Toolbox_SaveFile.Name = "Main_Toolbox_SaveFile";
            this.Main_Toolbox_SaveFile.Size = new System.Drawing.Size(29, 24);
            this.Main_Toolbox_SaveFile.Text = "Save file";
            this.Main_Toolbox_SaveFile.Click += new System.EventHandler(this.Main_Toolbox_SaveFile_Click);
            // 
            // Main_Toolbox
            // 
            this.Main_Toolbox.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Main_Toolbox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Main_Toolbox_OpenFile,
            this.Main_Toolbox_SaveFile});
            this.Main_Toolbox.Location = new System.Drawing.Point(0, 0);
            this.Main_Toolbox.Name = "Main_Toolbox";
            this.Main_Toolbox.Size = new System.Drawing.Size(891, 27);
            this.Main_Toolbox.TabIndex = 0;
            this.Main_Toolbox.Text = "toolStrip1";
            // 
            // Main_LayoutPanel
            // 
            this.Main_LayoutPanel.ColumnCount = 2;
            this.Main_LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Main_LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Main_LayoutPanel.Controls.Add(this.Main_SourcePicture, 0, 0);
            this.Main_LayoutPanel.Controls.Add(this.Main_ResultPicture, 1, 0);
            this.Main_LayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_LayoutPanel.Location = new System.Drawing.Point(0, 27);
            this.Main_LayoutPanel.Name = "Main_LayoutPanel";
            this.Main_LayoutPanel.RowCount = 1;
            this.Main_LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Main_LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Main_LayoutPanel.Size = new System.Drawing.Size(891, 459);
            this.Main_LayoutPanel.TabIndex = 3;
            // 
            // Main_SourcePicture
            // 
            this.Main_SourcePicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_SourcePicture.Location = new System.Drawing.Point(3, 3);
            this.Main_SourcePicture.Name = "Main_SourcePicture";
            this.Main_SourcePicture.Size = new System.Drawing.Size(439, 453);
            this.Main_SourcePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Main_SourcePicture.TabIndex = 0;
            this.Main_SourcePicture.TabStop = false;
            // 
            // Main_ResultPicture
            // 
            this.Main_ResultPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_ResultPicture.Location = new System.Drawing.Point(448, 3);
            this.Main_ResultPicture.Name = "Main_ResultPicture";
            this.Main_ResultPicture.Size = new System.Drawing.Size(440, 453);
            this.Main_ResultPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Main_ResultPicture.TabIndex = 1;
            this.Main_ResultPicture.TabStop = false;
            // 
            // Main_ContextMenu
            // 
            this.Main_ContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Main_ContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adjustBrightnesscontrastToolStripMenuItem,
            this.grayscaleToolStripMenuItem,
            this.rotateImage45DegreeToolStripMenuItem,
            this.reflectToolStripMenuItem,
            this.binarizeToolStripMenuItem,
            this.contoursToolStripMenuItem,
            this.erodeToolStripMenuItem,
            this.dilateToolStripMenuItem});
            this.Main_ContextMenu.Name = "Main_ContextMenu";
            this.Main_ContextMenu.Size = new System.Drawing.Size(252, 224);
            // 
            // adjustBrightnesscontrastToolStripMenuItem
            // 
            this.adjustBrightnesscontrastToolStripMenuItem.Name = "adjustBrightnesscontrastToolStripMenuItem";
            this.adjustBrightnesscontrastToolStripMenuItem.Size = new System.Drawing.Size(251, 24);
            this.adjustBrightnesscontrastToolStripMenuItem.Text = "Adjust brightness/contrast";
            this.adjustBrightnesscontrastToolStripMenuItem.Click += new System.EventHandler(this.adjustBrightnesscontrastToolStripMenuItem_Click);
            // 
            // grayscaleToolStripMenuItem
            // 
            this.grayscaleToolStripMenuItem.CheckOnClick = true;
            this.grayscaleToolStripMenuItem.Name = "grayscaleToolStripMenuItem";
            this.grayscaleToolStripMenuItem.Size = new System.Drawing.Size(251, 24);
            this.grayscaleToolStripMenuItem.Text = "Grayscale";
            this.grayscaleToolStripMenuItem.Click += new System.EventHandler(this.grayscaleToolStripMenuItem_Click);
            // 
            // rotateImage45DegreeToolStripMenuItem
            // 
            this.rotateImage45DegreeToolStripMenuItem.Name = "rotateImage45DegreeToolStripMenuItem";
            this.rotateImage45DegreeToolStripMenuItem.Size = new System.Drawing.Size(251, 24);
            this.rotateImage45DegreeToolStripMenuItem.Text = "Rotate Image 45 degree";
            this.rotateImage45DegreeToolStripMenuItem.Click += new System.EventHandler(this.rotateImage45DegreeToolStripMenuItem_Click);
            // 
            // reflectToolStripMenuItem
            // 
            this.reflectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verticalToolStripMenuItem,
            this.horizontalToolStripMenuItem});
            this.reflectToolStripMenuItem.Name = "reflectToolStripMenuItem";
            this.reflectToolStripMenuItem.Size = new System.Drawing.Size(251, 24);
            this.reflectToolStripMenuItem.Text = "Reflect ";
            this.reflectToolStripMenuItem.Click += new System.EventHandler(this.reflectVerticalToolStripMenuItem_Click);
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.verticalToolStripMenuItem.Text = "Vertical";
            this.verticalToolStripMenuItem.Click += new System.EventHandler(this.verticalToolStripMenuItem_Click);
            // 
            // horizontalToolStripMenuItem
            // 
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.horizontalToolStripMenuItem.Text = "Horizontal";
            this.horizontalToolStripMenuItem.Click += new System.EventHandler(this.horizontalToolStripMenuItem_Click);
            // 
            // binarizeToolStripMenuItem
            // 
            this.binarizeToolStripMenuItem.Name = "binarizeToolStripMenuItem";
            this.binarizeToolStripMenuItem.Size = new System.Drawing.Size(251, 24);
            this.binarizeToolStripMenuItem.Text = "Binarize";
            this.binarizeToolStripMenuItem.Click += new System.EventHandler(this.binarizeToolStripMenuItem_Click);
            // 
            // contoursToolStripMenuItem
            // 
            this.contoursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binarizeToolStripMenuItem1,
            this.cannyEdgesToolStripMenuItem,
            this.sobelToolStripMenuItem,
            this.laplasianToolStripMenuItem});
            this.contoursToolStripMenuItem.Name = "contoursToolStripMenuItem";
            this.contoursToolStripMenuItem.Size = new System.Drawing.Size(251, 24);
            this.contoursToolStripMenuItem.Text = "Contours";
            // 
            // binarizeToolStripMenuItem1
            // 
            this.binarizeToolStripMenuItem1.Name = "binarizeToolStripMenuItem1";
            this.binarizeToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.binarizeToolStripMenuItem1.Text = "Binarize contours";
            this.binarizeToolStripMenuItem1.Click += new System.EventHandler(this.binarizeToolStripMenuItem1_Click);
            // 
            // cannyEdgesToolStripMenuItem
            // 
            this.cannyEdgesToolStripMenuItem.Name = "cannyEdgesToolStripMenuItem";
            this.cannyEdgesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cannyEdgesToolStripMenuItem.Text = "Canny Edges";
            this.cannyEdgesToolStripMenuItem.Click += new System.EventHandler(this.cannyEdgesToolStripMenuItem_Click);
            // 
            // sobelToolStripMenuItem
            // 
            this.sobelToolStripMenuItem.Name = "sobelToolStripMenuItem";
            this.sobelToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sobelToolStripMenuItem.Text = "Sobel";
            this.sobelToolStripMenuItem.Click += new System.EventHandler(this.sobelToolStripMenuItem_Click);
            // 
            // laplasianToolStripMenuItem
            // 
            this.laplasianToolStripMenuItem.Name = "laplasianToolStripMenuItem";
            this.laplasianToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.laplasianToolStripMenuItem.Text = "Laplasian";
            this.laplasianToolStripMenuItem.Click += new System.EventHandler(this.laplasianToolStripMenuItem_Click);
            // 
            // erodeToolStripMenuItem
            // 
            this.erodeToolStripMenuItem.Name = "erodeToolStripMenuItem";
            this.erodeToolStripMenuItem.Size = new System.Drawing.Size(251, 24);
            this.erodeToolStripMenuItem.Text = "Erode";
            this.erodeToolStripMenuItem.Click += new System.EventHandler(this.erodeToolStripMenuItem_Click);
            // 
            // dilateToolStripMenuItem
            // 
            this.dilateToolStripMenuItem.Name = "dilateToolStripMenuItem";
            this.dilateToolStripMenuItem.Size = new System.Drawing.Size(251, 24);
            this.dilateToolStripMenuItem.Text = "Dilate";
            this.dilateToolStripMenuItem.Click += new System.EventHandler(this.dilateToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 508);
            this.ContextMenuStrip = this.Main_ContextMenu;
            this.Controls.Add(this.Main_LayoutPanel);
            this.Controls.Add(this.Main_status);
            this.Controls.Add(this.Main_Toolbox);
            this.Name = "MainForm";
            this.Text = "Computer Vision";
            this.Main_Toolbox.ResumeLayout(false);
            this.Main_Toolbox.PerformLayout();
            this.Main_LayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Main_SourcePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Main_ResultPicture)).EndInit();
            this.Main_ContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip Main_status;
        private System.Windows.Forms.ToolStripButton Main_Toolbox_OpenFile;
        private System.Windows.Forms.ToolStripButton Main_Toolbox_SaveFile;
        private System.Windows.Forms.ToolStrip Main_Toolbox;
        private System.Windows.Forms.TableLayoutPanel Main_LayoutPanel;
        private System.Windows.Forms.PictureBox Main_SourcePicture;
        private System.Windows.Forms.PictureBox Main_ResultPicture;
        private System.Windows.Forms.ContextMenuStrip Main_ContextMenu;
        private System.Windows.Forms.ToolStripMenuItem adjustBrightnesscontrastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayscaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateImage45DegreeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reflectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binarizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dilateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binarizeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cannyEdgesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laplasianToolStripMenuItem;
    }
}

