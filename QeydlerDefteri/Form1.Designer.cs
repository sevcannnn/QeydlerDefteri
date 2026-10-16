namespace QeydlerDefteri
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            faylToolStripMenuItem = new ToolStripMenuItem();
            yeniToolStripMenuItem1 = new ToolStripMenuItem();
            acToolStripMenuItem = new ToolStripMenuItem();
            saxlaToolStripMenuItem = new ToolStripMenuItem();
            cixisToolStripMenuItem = new ToolStripMenuItem();
            yeniToolStripMenuItem = new ToolStripMenuItem();
            sriftToolStripMenuItem = new ToolStripMenuItem();
            rengToolStripMenuItem = new ToolStripMenuItem();
            rtbText = new RichTextBox();
            statusStrip1 = new StatusStrip();
            lblCharCount = new ToolStripStatusLabel();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            fontDialog1 = new FontDialog();
            colorDialog1 = new ColorDialog();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { faylToolStripMenuItem, yeniToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // faylToolStripMenuItem
            // 
            faylToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { yeniToolStripMenuItem1, acToolStripMenuItem, saxlaToolStripMenuItem, cixisToolStripMenuItem });
            faylToolStripMenuItem.Name = "faylToolStripMenuItem";
            faylToolStripMenuItem.Size = new Size(48, 24);
            faylToolStripMenuItem.Text = "Fayl";
            // 
            // yeniToolStripMenuItem1
            // 
            yeniToolStripMenuItem1.Name = "yeniToolStripMenuItem1";
            yeniToolStripMenuItem1.Size = new Size(224, 26);
            yeniToolStripMenuItem1.Text = "Yeni";
            yeniToolStripMenuItem1.Click += yeniToolStripMenuItem1_Click;
            // 
            // acToolStripMenuItem
            // 
            acToolStripMenuItem.Name = "acToolStripMenuItem";
            acToolStripMenuItem.Size = new Size(224, 26);
            acToolStripMenuItem.Text = "Ac";
            acToolStripMenuItem.Click += acToolStripMenuItem_Click;
            // 
            // saxlaToolStripMenuItem
            // 
            saxlaToolStripMenuItem.Name = "saxlaToolStripMenuItem";
            saxlaToolStripMenuItem.Size = new Size(224, 26);
            saxlaToolStripMenuItem.Text = "Saxla";
            saxlaToolStripMenuItem.Click += saxlaToolStripMenuItem_Click;
            // 
            // cixisToolStripMenuItem
            // 
            cixisToolStripMenuItem.Name = "cixisToolStripMenuItem";
            cixisToolStripMenuItem.Size = new Size(224, 26);
            cixisToolStripMenuItem.Text = "Cixis";
            cixisToolStripMenuItem.Click += cixisToolStripMenuItem_Click;
            // 
            // yeniToolStripMenuItem
            // 
            yeniToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sriftToolStripMenuItem, rengToolStripMenuItem });
            yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            yeniToolStripMenuItem.Size = new Size(70, 24);
            yeniToolStripMenuItem.Text = "Format";
            yeniToolStripMenuItem.Click += yeniToolStripMenuItem_Click;
            // 
            // sriftToolStripMenuItem
            // 
            sriftToolStripMenuItem.Name = "sriftToolStripMenuItem";
            sriftToolStripMenuItem.Size = new Size(126, 26);
            sriftToolStripMenuItem.Text = "Srift";
            sriftToolStripMenuItem.Click += sriftToolStripMenuItem_Click;
            // 
            // rengToolStripMenuItem
            // 
            rengToolStripMenuItem.Name = "rengToolStripMenuItem";
            rengToolStripMenuItem.Size = new Size(126, 26);
            rengToolStripMenuItem.Text = "Reng";
            rengToolStripMenuItem.Click += rengToolStripMenuItem_Click;
            // 
            // rtbText
            // 
            rtbText.Dock = DockStyle.Fill;
            rtbText.Location = new Point(0, 28);
            rtbText.Name = "rtbText";
            rtbText.Size = new Size(800, 422);
            rtbText.TabIndex = 1;
            rtbText.Text = "";
            rtbText.TextChanged += rtbText_TextChanged;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblCharCount });
            statusStrip1.Location = new Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 26);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblCharCount
            // 
            lblCharCount.Name = "lblCharCount";
            lblCharCount.Size = new Size(102, 20);
            lblCharCount.Text = "Simvol sayi : 0";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(rtbText);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private RichTextBox rtbText;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblCharCount;
        private ToolStripMenuItem faylToolStripMenuItem;
        private ToolStripMenuItem yeniToolStripMenuItem1;
        private ToolStripMenuItem acToolStripMenuItem;
        private ToolStripMenuItem saxlaToolStripMenuItem;
        private ToolStripMenuItem cixisToolStripMenuItem;
        private ToolStripMenuItem yeniToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private FontDialog fontDialog1;
        private ColorDialog colorDialog1;
        private ToolStripMenuItem sriftToolStripMenuItem;
        private ToolStripMenuItem rengToolStripMenuItem;
    }
}
