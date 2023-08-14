namespace ImageProcessor
{
    partial class MainForm
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
            this.txtFolderName = new System.Windows.Forms.TextBox();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.pbSource = new System.Windows.Forms.PictureBox();
            this.pbTarget = new System.Windows.Forms.PictureBox();
            this.tbAngleSelector = new System.Windows.Forms.TrackBar();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblAngle = new System.Windows.Forms.Label();
            this.btnDecrement = new System.Windows.Forms.Button();
            this.btnIncrement = new System.Windows.Forms.Button();
            this.btnDecrementLarge = new System.Windows.Forms.Button();
            this.btnIncrementLarge = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.cropBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTarget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAngleSelector)).BeginInit();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFolderName
            // 
            this.txtFolderName.Enabled = false;
            this.txtFolderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFolderName.Location = new System.Drawing.Point(25, 24);
            this.txtFolderName.Name = "txtFolderName";
            this.txtFolderName.Size = new System.Drawing.Size(519, 22);
            this.txtFolderName.TabIndex = 0;
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Location = new System.Drawing.Point(550, 24);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFolder.TabIndex = 1;
            this.btnOpenFolder.Text = "Klasörü Seç";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // pbSource
            // 
            this.pbSource.Location = new System.Drawing.Point(153, 72);
            this.pbSource.Name = "pbSource";
            this.pbSource.Size = new System.Drawing.Size(400, 400);
            this.pbSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbSource.TabIndex = 2;
            this.pbSource.TabStop = false;
            // 
            // pbTarget
            // 
            this.pbTarget.Location = new System.Drawing.Point(718, 72);
            this.pbTarget.Name = "pbTarget";
            this.pbTarget.Size = new System.Drawing.Size(400, 400);
            this.pbTarget.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbTarget.TabIndex = 3;
            this.pbTarget.TabStop = false;
            // 
            // tbAngleSelector
            // 
            this.tbAngleSelector.Location = new System.Drawing.Point(252, 496);
            this.tbAngleSelector.Maximum = 360;
            this.tbAngleSelector.Minimum = -360;
            this.tbAngleSelector.Name = "tbAngleSelector";
            this.tbAngleSelector.Size = new System.Drawing.Size(839, 45);
            this.tbAngleSelector.TabIndex = 4;
            this.tbAngleSelector.ValueChanged += new System.EventHandler(this.tbAngleSelector_ValueChanged);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(625, 600);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 50);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(1249, 310);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(10, 13);
            this.lblCount.TabIndex = 6;
            this.lblCount.Text = "-";
            // 
            // lblAngle
            // 
            this.lblAngle.AutoSize = true;
            this.lblAngle.Location = new System.Drawing.Point(664, 544);
            this.lblAngle.Name = "lblAngle";
            this.lblAngle.Size = new System.Drawing.Size(10, 13);
            this.lblAngle.TabIndex = 7;
            this.lblAngle.Text = "-";
            // 
            // btnDecrement
            // 
            this.btnDecrement.Location = new System.Drawing.Point(618, 539);
            this.btnDecrement.Name = "btnDecrement";
            this.btnDecrement.Size = new System.Drawing.Size(30, 23);
            this.btnDecrement.TabIndex = 8;
            this.btnDecrement.Text = "<";
            this.btnDecrement.UseVisualStyleBackColor = true;
            this.btnDecrement.Click += new System.EventHandler(this.btnDecrement_Click);
            // 
            // btnIncrement
            // 
            this.btnIncrement.Location = new System.Drawing.Point(696, 539);
            this.btnIncrement.Name = "btnIncrement";
            this.btnIncrement.Size = new System.Drawing.Size(30, 23);
            this.btnIncrement.TabIndex = 9;
            this.btnIncrement.Text = ">";
            this.btnIncrement.UseVisualStyleBackColor = true;
            this.btnIncrement.Click += new System.EventHandler(this.btnIncrement_Click);
            // 
            // btnDecrementLarge
            // 
            this.btnDecrementLarge.Location = new System.Drawing.Point(582, 539);
            this.btnDecrementLarge.Name = "btnDecrementLarge";
            this.btnDecrementLarge.Size = new System.Drawing.Size(30, 23);
            this.btnDecrementLarge.TabIndex = 10;
            this.btnDecrementLarge.Text = "<<";
            this.btnDecrementLarge.UseVisualStyleBackColor = true;
            this.btnDecrementLarge.Click += new System.EventHandler(this.btnDecrementLarge_Click);
            // 
            // btnIncrementLarge
            // 
            this.btnIncrementLarge.Location = new System.Drawing.Point(732, 539);
            this.btnIncrementLarge.Name = "btnIncrementLarge";
            this.btnIncrementLarge.Size = new System.Drawing.Size(30, 23);
            this.btnIncrementLarge.TabIndex = 11;
            this.btnIncrementLarge.Text = ">>";
            this.btnIncrementLarge.UseVisualStyleBackColor = true;
            this.btnIncrementLarge.Click += new System.EventHandler(this.btnIncrementLarge_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.Location = new System.Drawing.Point(107, 600);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(101, 50);
            this.btnSil.TabIndex = 12;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Location = new System.Drawing.Point(690, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 1);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel2.Location = new System.Drawing.Point(690, 177);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(442, 1);
            this.panel2.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel3.Location = new System.Drawing.Point(690, 162);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(442, 1);
            this.panel3.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel4.Location = new System.Drawing.Point(690, 192);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(442, 1);
            this.panel4.TabIndex = 16;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel5.Location = new System.Drawing.Point(690, 207);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(442, 1);
            this.panel5.TabIndex = 17;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel6.Location = new System.Drawing.Point(690, 222);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(442, 1);
            this.panel6.TabIndex = 18;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel7.Location = new System.Drawing.Point(690, 237);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(442, 1);
            this.panel7.TabIndex = 19;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Location = new System.Drawing.Point(690, 252);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(442, 1);
            this.panel8.TabIndex = 20;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel9.Location = new System.Drawing.Point(0, 27);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(442, 1);
            this.panel9.TabIndex = 22;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel10.Location = new System.Drawing.Point(0, 12);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(442, 1);
            this.panel10.TabIndex = 21;
            // 
            // cropBtn
            // 
            this.cropBtn.Location = new System.Drawing.Point(1198, 72);
            this.cropBtn.Name = "cropBtn";
            this.cropBtn.Size = new System.Drawing.Size(126, 23);
            this.cropBtn.TabIndex = 21;
            this.cropBtn.Text = "crop";
            this.cropBtn.UseVisualStyleBackColor = true;
            this.cropBtn.Click += new System.EventHandler(this.btnCrop_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 682);
            this.Controls.Add(this.cropBtn);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnIncrementLarge);
            this.Controls.Add(this.btnDecrementLarge);
            this.Controls.Add(this.btnIncrement);
            this.Controls.Add(this.btnDecrement);
            this.Controls.Add(this.lblAngle);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbAngleSelector);
            this.Controls.Add(this.pbTarget);
            this.Controls.Add(this.pbSource);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.txtFolderName);
            this.Name = "MainForm";
            this.Text = "-";
            ((System.ComponentModel.ISupportInitialize)(this.pbSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTarget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAngleSelector)).EndInit();
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFolderName;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.PictureBox pbSource;
        private System.Windows.Forms.PictureBox pbTarget;
        private System.Windows.Forms.TrackBar tbAngleSelector;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblAngle;
        private System.Windows.Forms.Button btnDecrement;
        private System.Windows.Forms.Button btnIncrement;
        private System.Windows.Forms.Button btnDecrementLarge;
        private System.Windows.Forms.Button btnIncrementLarge;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button cropBtn;
    }
}

