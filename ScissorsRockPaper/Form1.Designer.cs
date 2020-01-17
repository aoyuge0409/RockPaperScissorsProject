namespace ScissorsRockPaper
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnPlay = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imgSystemRock = new System.Windows.Forms.PictureBox();
            this.imgSystemScissors = new System.Windows.Forms.PictureBox();
            this.imgPaperSystem = new System.Windows.Forms.PictureBox();
            this.imgRockUser = new System.Windows.Forms.PictureBox();
            this.imgScissorsUser = new System.Windows.Forms.PictureBox();
            this.imgPaperUser = new System.Windows.Forms.PictureBox();
            this.lblYou = new System.Windows.Forms.Label();
            this.lblPc = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.btnPlayAgaing = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgSystemRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSystemScissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPaperSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRockUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgScissorsUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPaperUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Gold;
            this.btnPlay.Enabled = false;
            this.btnPlay.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(255, 427);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(120, 40);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imgSystemRock
            // 
            this.imgSystemRock.Image = ((System.Drawing.Image)(resources.GetObject("imgSystemRock.Image")));
            this.imgSystemRock.Location = new System.Drawing.Point(485, 157);
            this.imgSystemRock.Name = "imgSystemRock";
            this.imgSystemRock.Size = new System.Drawing.Size(148, 144);
            this.imgSystemRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSystemRock.TabIndex = 11;
            this.imgSystemRock.TabStop = false;
            this.imgSystemRock.Visible = false;
            this.imgSystemRock.WaitOnLoad = true;
            // 
            // imgSystemScissors
            // 
            this.imgSystemScissors.Image = ((System.Drawing.Image)(resources.GetObject("imgSystemScissors.Image")));
            this.imgSystemScissors.Location = new System.Drawing.Point(485, 307);
            this.imgSystemScissors.Name = "imgSystemScissors";
            this.imgSystemScissors.Size = new System.Drawing.Size(148, 144);
            this.imgSystemScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSystemScissors.TabIndex = 10;
            this.imgSystemScissors.TabStop = false;
            this.imgSystemScissors.Visible = false;
            this.imgSystemScissors.WaitOnLoad = true;
            // 
            // imgPaperSystem
            // 
            this.imgPaperSystem.Image = ((System.Drawing.Image)(resources.GetObject("imgPaperSystem.Image")));
            this.imgPaperSystem.Location = new System.Drawing.Point(485, 7);
            this.imgPaperSystem.Name = "imgPaperSystem";
            this.imgPaperSystem.Size = new System.Drawing.Size(148, 144);
            this.imgPaperSystem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPaperSystem.TabIndex = 9;
            this.imgPaperSystem.TabStop = false;
            this.imgPaperSystem.Visible = false;
            // 
            // imgRockUser
            // 
            this.imgRockUser.Image = ((System.Drawing.Image)(resources.GetObject("imgRockUser.Image")));
            this.imgRockUser.Location = new System.Drawing.Point(12, 157);
            this.imgRockUser.Name = "imgRockUser";
            this.imgRockUser.Size = new System.Drawing.Size(148, 144);
            this.imgRockUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgRockUser.TabIndex = 14;
            this.imgRockUser.TabStop = false;
            this.imgRockUser.WaitOnLoad = true;
            this.imgRockUser.Click += new System.EventHandler(this.ImgNameUser_Click);
            // 
            // imgScissorsUser
            // 
            this.imgScissorsUser.Image = ((System.Drawing.Image)(resources.GetObject("imgScissorsUser.Image")));
            this.imgScissorsUser.Location = new System.Drawing.Point(10, 307);
            this.imgScissorsUser.Name = "imgScissorsUser";
            this.imgScissorsUser.Size = new System.Drawing.Size(148, 144);
            this.imgScissorsUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgScissorsUser.TabIndex = 13;
            this.imgScissorsUser.TabStop = false;
            this.imgScissorsUser.WaitOnLoad = true;
            this.imgScissorsUser.Click += new System.EventHandler(this.ImgScissorsUser_Click);
            // 
            // imgPaperUser
            // 
            this.imgPaperUser.BackColor = System.Drawing.Color.Transparent;
            this.imgPaperUser.Image = ((System.Drawing.Image)(resources.GetObject("imgPaperUser.Image")));
            this.imgPaperUser.Location = new System.Drawing.Point(12, 7);
            this.imgPaperUser.Name = "imgPaperUser";
            this.imgPaperUser.Size = new System.Drawing.Size(148, 144);
            this.imgPaperUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPaperUser.TabIndex = 12;
            this.imgPaperUser.TabStop = false;
            this.imgPaperUser.Click += new System.EventHandler(this.ImgPaperUser_Click);
            // 
            // lblYou
            // 
            this.lblYou.AutoSize = true;
            this.lblYou.BackColor = System.Drawing.Color.Violet;
            this.lblYou.Font = new System.Drawing.Font("Verdana", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYou.Location = new System.Drawing.Point(16, 478);
            this.lblYou.Name = "lblYou";
            this.lblYou.Size = new System.Drawing.Size(143, 65);
            this.lblYou.TabIndex = 16;
            this.lblYou.Text = "You";
            this.lblYou.Visible = false;
            // 
            // lblPc
            // 
            this.lblPc.AutoSize = true;
            this.lblPc.BackColor = System.Drawing.Color.Violet;
            this.lblPc.Font = new System.Drawing.Font("Verdana", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPc.Location = new System.Drawing.Point(513, 478);
            this.lblPc.Name = "lblPc";
            this.lblPc.Size = new System.Drawing.Size(107, 65);
            this.lblPc.TabIndex = 17;
            this.lblPc.Text = "PC";
            this.lblPc.Visible = false;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Verdana", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(12, 9);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 48);
            this.lblResult.TabIndex = 18;
            this.lblResult.Visible = false;
            this.lblResult.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.BackColor = System.Drawing.Color.Gold;
            this.lblStart.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(204, -2);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(236, 34);
            this.lblStart.TabIndex = 19;
            this.lblStart.Text = "Make your choice";
            // 
            // btnPlayAgaing
            // 
            this.btnPlayAgaing.AutoSize = true;
            this.btnPlayAgaing.BackColor = System.Drawing.Color.Gold;
            this.btnPlayAgaing.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgaing.Location = new System.Drawing.Point(255, 478);
            this.btnPlayAgaing.Name = "btnPlayAgaing";
            this.btnPlayAgaing.Size = new System.Drawing.Size(120, 40);
            this.btnPlayAgaing.TabIndex = 15;
            this.btnPlayAgaing.Text = "Play again";
            this.btnPlayAgaing.UseVisualStyleBackColor = false;
            this.btnPlayAgaing.Visible = false;
            this.btnPlayAgaing.Click += new System.EventHandler(this.BtnPlayAgaing_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(649, 556);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(645, 552);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblPc);
            this.Controls.Add(this.lblYou);
            this.Controls.Add(this.btnPlayAgaing);
            this.Controls.Add(this.imgRockUser);
            this.Controls.Add(this.imgScissorsUser);
            this.Controls.Add(this.imgPaperUser);
            this.Controls.Add(this.imgSystemRock);
            this.Controls.Add(this.imgSystemScissors);
            this.Controls.Add(this.imgPaperSystem);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Rock Paper Scissors ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgSystemRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSystemScissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPaperSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRockUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgScissorsUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPaperUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox imgSystemRock;
        private System.Windows.Forms.PictureBox imgSystemScissors;
        private System.Windows.Forms.PictureBox imgPaperSystem;
        private System.Windows.Forms.PictureBox imgRockUser;
        private System.Windows.Forms.PictureBox imgScissorsUser;
        private System.Windows.Forms.PictureBox imgPaperUser;
        private System.Windows.Forms.Label lblYou;
        private System.Windows.Forms.Label lblPc;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Button btnPlayAgaing;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

