//#####################################################################################
//★★★★★★★           http://www.cnpopsoft.com [华普软件]           ★★★★★★★
//★★★★★★★           华普软件-VB、C#专业论文与源码荟萃！           ★★★★★★★
//#####################################################################################

namespace CNPOPSOFT.Controls
{
    partial class frmMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnActivate = new System.Windows.Forms.Button();
            this.btnDesactivate = new System.Windows.Forms.Button();
            this.nudOuterCircleRadius = new System.Windows.Forms.NumericUpDown();
            this.lblOuterCircleRadius = new System.Windows.Forms.Label();
            this.lblInnerCircleRadius = new System.Windows.Forms.Label();
            this.nudInnerCircleRadius = new System.Windows.Forms.NumericUpDown();
            this.lblNumberSpoke = new System.Windows.Forms.Label();
            this.nudNumberSpoke = new System.Windows.Forms.NumericUpDown();
            this.nudSpokesThickness = new System.Windows.Forms.NumericUpDown();
            this.lblSpokeThickness = new System.Windows.Forms.Label();
            this.cbColors = new System.Windows.Forms.ComboBox();
            this.btnMacOSXStyle = new System.Windows.Forms.Button();
            this.btnFireFoxStyle = new System.Windows.Forms.Button();
            this.lblLoadingCircle = new System.Windows.Forms.Label();
            this.lnkMartinGagne = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRotationSpeed = new System.Windows.Forms.Label();
            this.nudRotationSpeed = new System.Windows.Forms.NumericUpDown();
            this.btnIE7Style = new System.Windows.Forms.Button();
            this.lblCustomizable = new System.Windows.Forms.Label();
            this.lblFireFox = new System.Windows.Forms.Label();
            this.lblIE7Style = new System.Windows.Forms.Label();
            this.lblMacOSXStyle = new System.Windows.Forms.Label();
            this.loadingCircleMacOSX = new CNPOPSOFT.Controls.LoadingCircle();
            this.loadingCircleIE7 = new CNPOPSOFT.Controls.LoadingCircle();
            this.loadingCircleFF = new CNPOPSOFT.Controls.LoadingCircle();
            this.loadingCircle = new CNPOPSOFT.Controls.LoadingCircle();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.nudOuterCircleRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInnerCircleRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberSpoke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpokesThickness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRotationSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActivate
            // 
            this.btnActivate.ForeColor = System.Drawing.Color.Black;
            this.btnActivate.Location = new System.Drawing.Point(12, 44);
            this.btnActivate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(97, 25);
            this.btnActivate.TabIndex = 1;
            this.btnActivate.Text = "开始(&S)";
            this.btnActivate.UseVisualStyleBackColor = true;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // btnDesactivate
            // 
            this.btnDesactivate.ForeColor = System.Drawing.Color.Black;
            this.btnDesactivate.Location = new System.Drawing.Point(118, 44);
            this.btnDesactivate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDesactivate.Name = "btnDesactivate";
            this.btnDesactivate.Size = new System.Drawing.Size(97, 25);
            this.btnDesactivate.TabIndex = 2;
            this.btnDesactivate.Text = "停止(&T)";
            this.btnDesactivate.UseVisualStyleBackColor = true;
            this.btnDesactivate.Click += new System.EventHandler(this.btnDesactivate_Click);
            // 
            // nudOuterCircleRadius
            // 
            this.nudOuterCircleRadius.Location = new System.Drawing.Point(436, 196);
            this.nudOuterCircleRadius.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudOuterCircleRadius.Name = "nudOuterCircleRadius";
            this.nudOuterCircleRadius.Size = new System.Drawing.Size(98, 22);
            this.nudOuterCircleRadius.TabIndex = 3;
            this.nudOuterCircleRadius.ValueChanged += new System.EventHandler(this.nudOuterCircleRadius_ValueChanged);
            // 
            // lblOuterCircleRadius
            // 
            this.lblOuterCircleRadius.AutoSize = true;
            this.lblOuterCircleRadius.ForeColor = System.Drawing.Color.White;
            this.lblOuterCircleRadius.Location = new System.Drawing.Point(376, 197);
            this.lblOuterCircleRadius.Name = "lblOuterCircleRadius";
            this.lblOuterCircleRadius.Size = new System.Drawing.Size(52, 16);
            this.lblOuterCircleRadius.TabIndex = 4;
            this.lblOuterCircleRadius.Text = "外圆半径";
            // 
            // lblInnerCircleRadius
            // 
            this.lblInnerCircleRadius.AutoSize = true;
            this.lblInnerCircleRadius.ForeColor = System.Drawing.Color.White;
            this.lblInnerCircleRadius.Location = new System.Drawing.Point(376, 157);
            this.lblInnerCircleRadius.Name = "lblInnerCircleRadius";
            this.lblInnerCircleRadius.Size = new System.Drawing.Size(52, 16);
            this.lblInnerCircleRadius.TabIndex = 6;
            this.lblInnerCircleRadius.Text = "内圆半径";
            // 
            // nudInnerCircleRadius
            // 
            this.nudInnerCircleRadius.Location = new System.Drawing.Point(436, 158);
            this.nudInnerCircleRadius.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudInnerCircleRadius.Name = "nudInnerCircleRadius";
            this.nudInnerCircleRadius.Size = new System.Drawing.Size(98, 22);
            this.nudInnerCircleRadius.TabIndex = 5;
            this.nudInnerCircleRadius.ValueChanged += new System.EventHandler(this.nudInnerCircleRadius_ValueChanged);
            // 
            // lblNumberSpoke
            // 
            this.lblNumberSpoke.AutoSize = true;
            this.lblNumberSpoke.ForeColor = System.Drawing.Color.White;
            this.lblNumberSpoke.Location = new System.Drawing.Point(376, 89);
            this.lblNumberSpoke.Name = "lblNumberSpoke";
            this.lblNumberSpoke.Size = new System.Drawing.Size(52, 16);
            this.lblNumberSpoke.TabIndex = 7;
            this.lblNumberSpoke.Text = "辐条数量";
            // 
            // nudNumberSpoke
            // 
            this.nudNumberSpoke.Location = new System.Drawing.Point(436, 88);
            this.nudNumberSpoke.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudNumberSpoke.Name = "nudNumberSpoke";
            this.nudNumberSpoke.Size = new System.Drawing.Size(98, 22);
            this.nudNumberSpoke.TabIndex = 8;
            this.nudNumberSpoke.ValueChanged += new System.EventHandler(this.nudNumberSpoke_ValueChanged);
            // 
            // nudSpokesThickness
            // 
            this.nudSpokesThickness.Location = new System.Drawing.Point(436, 123);
            this.nudSpokesThickness.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudSpokesThickness.Name = "nudSpokesThickness";
            this.nudSpokesThickness.Size = new System.Drawing.Size(98, 22);
            this.nudSpokesThickness.TabIndex = 10;
            this.nudSpokesThickness.ValueChanged += new System.EventHandler(this.nudSpokesThickness_ValueChanged);
            // 
            // lblSpokeThickness
            // 
            this.lblSpokeThickness.AutoSize = true;
            this.lblSpokeThickness.ForeColor = System.Drawing.Color.White;
            this.lblSpokeThickness.Location = new System.Drawing.Point(376, 125);
            this.lblSpokeThickness.Name = "lblSpokeThickness";
            this.lblSpokeThickness.Size = new System.Drawing.Size(52, 16);
            this.lblSpokeThickness.TabIndex = 9;
            this.lblSpokeThickness.Text = "辐条粗细";
            // 
            // cbColors
            // 
            this.cbColors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColors.FormattingEnabled = true;
            this.cbColors.Location = new System.Drawing.Point(436, 265);
            this.cbColors.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbColors.Name = "cbColors";
            this.cbColors.Size = new System.Drawing.Size(97, 24);
            this.cbColors.TabIndex = 11;
            this.cbColors.SelectedIndexChanged += new System.EventHandler(this.cbColors_SelectedIndexChanged);
            // 
            // btnMacOSXStyle
            // 
            this.btnMacOSXStyle.ForeColor = System.Drawing.Color.Black;
            this.btnMacOSXStyle.Location = new System.Drawing.Point(224, 44);
            this.btnMacOSXStyle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMacOSXStyle.Name = "btnMacOSXStyle";
            this.btnMacOSXStyle.Size = new System.Drawing.Size(97, 25);
            this.btnMacOSXStyle.TabIndex = 12;
            this.btnMacOSXStyle.Text = "MacOS X 风格";
            this.btnMacOSXStyle.UseVisualStyleBackColor = true;
            this.btnMacOSXStyle.Click += new System.EventHandler(this.btnMacOSXStyle_Click);
            // 
            // btnFireFoxStyle
            // 
            this.btnFireFoxStyle.ForeColor = System.Drawing.Color.Black;
            this.btnFireFoxStyle.Location = new System.Drawing.Point(330, 44);
            this.btnFireFoxStyle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFireFoxStyle.Name = "btnFireFoxStyle";
            this.btnFireFoxStyle.Size = new System.Drawing.Size(97, 25);
            this.btnFireFoxStyle.TabIndex = 13;
            this.btnFireFoxStyle.Text = "FireFox 风格";
            this.btnFireFoxStyle.UseVisualStyleBackColor = true;
            this.btnFireFoxStyle.Click += new System.EventHandler(this.btnFireFoxStyle_Click);
            // 
            // lblLoadingCircle
            // 
            this.lblLoadingCircle.AutoSize = true;
            this.lblLoadingCircle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadingCircle.ForeColor = System.Drawing.Color.White;
            this.lblLoadingCircle.Location = new System.Drawing.Point(8, 9);
            this.lblLoadingCircle.Name = "lblLoadingCircle";
            this.lblLoadingCircle.Size = new System.Drawing.Size(214, 22);
            this.lblLoadingCircle.TabIndex = 15;
            this.lblLoadingCircle.Text = "LoadingCircle v1.1 Demo";
            this.lblLoadingCircle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lnkMartinGagne
            // 
            this.lnkMartinGagne.AutoSize = true;
            this.lnkMartinGagne.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lnkMartinGagne.Location = new System.Drawing.Point(231, 15);
            this.lnkMartinGagne.Name = "lnkMartinGagne";
            this.lnkMartinGagne.Size = new System.Drawing.Size(90, 16);
            this.lnkMartinGagne.TabIndex = 17;
            this.lnkMartinGagne.TabStop = true;
            this.lnkMartinGagne.Text = "by Martin Gagn";
            this.lnkMartinGagne.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkMartinGagne_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(376, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "颜色";
            // 
            // lblRotationSpeed
            // 
            this.lblRotationSpeed.AutoSize = true;
            this.lblRotationSpeed.ForeColor = System.Drawing.Color.White;
            this.lblRotationSpeed.Location = new System.Drawing.Point(376, 232);
            this.lblRotationSpeed.Name = "lblRotationSpeed";
            this.lblRotationSpeed.Size = new System.Drawing.Size(52, 16);
            this.lblRotationSpeed.TabIndex = 20;
            this.lblRotationSpeed.Text = "旋转速度";
            // 
            // nudRotationSpeed
            // 
            this.nudRotationSpeed.Location = new System.Drawing.Point(436, 230);
            this.nudRotationSpeed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudRotationSpeed.Name = "nudRotationSpeed";
            this.nudRotationSpeed.Size = new System.Drawing.Size(98, 22);
            this.nudRotationSpeed.TabIndex = 19;
            this.nudRotationSpeed.ValueChanged += new System.EventHandler(this.nudRotationSpeed_ValueChanged);
            // 
            // btnIE7Style
            // 
            this.btnIE7Style.ForeColor = System.Drawing.Color.Black;
            this.btnIE7Style.Location = new System.Drawing.Point(436, 44);
            this.btnIE7Style.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIE7Style.Name = "btnIE7Style";
            this.btnIE7Style.Size = new System.Drawing.Size(97, 25);
            this.btnIE7Style.TabIndex = 21;
            this.btnIE7Style.Text = "IE 7 风格";
            this.btnIE7Style.UseVisualStyleBackColor = true;
            this.btnIE7Style.Click += new System.EventHandler(this.btnIE7Style_Click);
            // 
            // lblCustomizable
            // 
            this.lblCustomizable.AutoSize = true;
            this.lblCustomizable.ForeColor = System.Drawing.Color.White;
            this.lblCustomizable.Location = new System.Drawing.Point(12, 87);
            this.lblCustomizable.Name = "lblCustomizable";
            this.lblCustomizable.Size = new System.Drawing.Size(63, 16);
            this.lblCustomizable.TabIndex = 23;
            this.lblCustomizable.Text = "自定义风格";
            // 
            // lblFireFox
            // 
            this.lblFireFox.AutoSize = true;
            this.lblFireFox.ForeColor = System.Drawing.Color.White;
            this.lblFireFox.Location = new System.Drawing.Point(183, 87);
            this.lblFireFox.Name = "lblFireFox";
            this.lblFireFox.Size = new System.Drawing.Size(71, 16);
            this.lblFireFox.TabIndex = 25;
            this.lblFireFox.Text = "FireFox 风格";
            // 
            // lblIE7Style
            // 
            this.lblIE7Style.AutoSize = true;
            this.lblIE7Style.ForeColor = System.Drawing.Color.White;
            this.lblIE7Style.Location = new System.Drawing.Point(12, 187);
            this.lblIE7Style.Name = "lblIE7Style";
            this.lblIE7Style.Size = new System.Drawing.Size(48, 16);
            this.lblIE7Style.TabIndex = 27;
            this.lblIE7Style.Text = "IE7 风格";
            // 
            // lblMacOSXStyle
            // 
            this.lblMacOSXStyle.AutoSize = true;
            this.lblMacOSXStyle.ForeColor = System.Drawing.Color.White;
            this.lblMacOSXStyle.Location = new System.Drawing.Point(183, 187);
            this.lblMacOSXStyle.Name = "lblMacOSXStyle";
            this.lblMacOSXStyle.Size = new System.Drawing.Size(81, 16);
            this.lblMacOSXStyle.TabIndex = 29;
            this.lblMacOSXStyle.Text = "Mac OSX 风格";
            // 
            // loadingCircleMacOSX
            // 
            this.loadingCircleMacOSX.Active = false;
            this.loadingCircleMacOSX.BackColor = System.Drawing.Color.Transparent;
            this.loadingCircleMacOSX.Color = System.Drawing.Color.White;
            this.loadingCircleMacOSX.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.loadingCircleMacOSX.InnerCircleRadius = 5;
            this.loadingCircleMacOSX.Location = new System.Drawing.Point(270, 187);
            this.loadingCircleMacOSX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loadingCircleMacOSX.Name = "loadingCircleMacOSX";
            this.loadingCircleMacOSX.NumberSpoke = 12;
            this.loadingCircleMacOSX.OuterCircleRadius = 11;
            this.loadingCircleMacOSX.RotationSpeed = 80;
            this.loadingCircleMacOSX.Size = new System.Drawing.Size(96, 92);
            this.loadingCircleMacOSX.SpokeThickness = 2;
            this.loadingCircleMacOSX.StylePreset = CNPOPSOFT.Controls.LoadingCircle.StylePresets.MacOSX;
            this.loadingCircleMacOSX.TabIndex = 28;
            this.loadingCircleMacOSX.Text = "loadingCircle1";
            // 
            // loadingCircleIE7
            // 
            this.loadingCircleIE7.Active = false;
            this.loadingCircleIE7.BackColor = System.Drawing.Color.Transparent;
            this.loadingCircleIE7.Color = System.Drawing.Color.White;
            this.loadingCircleIE7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.loadingCircleIE7.InnerCircleRadius = 8;
            this.loadingCircleIE7.Location = new System.Drawing.Point(81, 187);
            this.loadingCircleIE7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loadingCircleIE7.Name = "loadingCircleIE7";
            this.loadingCircleIE7.NumberSpoke = 24;
            this.loadingCircleIE7.OuterCircleRadius = 9;
            this.loadingCircleIE7.RotationSpeed = 80;
            this.loadingCircleIE7.Size = new System.Drawing.Size(96, 92);
            this.loadingCircleIE7.SpokeThickness = 4;
            this.loadingCircleIE7.StylePreset = CNPOPSOFT.Controls.LoadingCircle.StylePresets.IE7;
            this.loadingCircleIE7.TabIndex = 26;
            this.loadingCircleIE7.Text = "loadingCircle1";
            // 
            // loadingCircleFF
            // 
            this.loadingCircleFF.Active = false;
            this.loadingCircleFF.BackColor = System.Drawing.Color.Transparent;
            this.loadingCircleFF.Color = System.Drawing.Color.White;
            this.loadingCircleFF.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.loadingCircleFF.InnerCircleRadius = 6;
            this.loadingCircleFF.Location = new System.Drawing.Point(270, 86);
            this.loadingCircleFF.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loadingCircleFF.Name = "loadingCircleFF";
            this.loadingCircleFF.NumberSpoke = 9;
            this.loadingCircleFF.OuterCircleRadius = 7;
            this.loadingCircleFF.RotationSpeed = 80;
            this.loadingCircleFF.Size = new System.Drawing.Size(96, 92);
            this.loadingCircleFF.SpokeThickness = 4;
            this.loadingCircleFF.StylePreset = CNPOPSOFT.Controls.LoadingCircle.StylePresets.Firefox;
            this.loadingCircleFF.TabIndex = 24;
            this.loadingCircleFF.Text = "loadingCircleFF";
            // 
            // loadingCircle
            // 
            this.loadingCircle.Active = false;
            this.loadingCircle.BackColor = System.Drawing.Color.Transparent;
            this.loadingCircle.Color = System.Drawing.Color.DarkOrange;
            this.loadingCircle.ForeColor = System.Drawing.Color.Red;
            this.loadingCircle.InnerCircleRadius = 5;
            this.loadingCircle.Location = new System.Drawing.Point(81, 87);
            this.loadingCircle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loadingCircle.Name = "loadingCircle";
            this.loadingCircle.NumberSpoke = 9;
            this.loadingCircle.OuterCircleRadius = 12;
            this.loadingCircle.RotationSpeed = 90;
            this.loadingCircle.Size = new System.Drawing.Size(96, 92);
            this.loadingCircle.SpokeThickness = 7;
            this.loadingCircle.StylePreset = CNPOPSOFT.Controls.LoadingCircle.StylePresets.Firefox;
            this.loadingCircle.TabIndex = 14;
            this.loadingCircle.Text = "loadingCircle";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Chartreuse;
            this.linkLabel1.Location = new System.Drawing.Point(438, 14);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(96, 16);
            this.linkLabel1.TabIndex = 30;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "欢迎光临华普软件";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(544, 304);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblMacOSXStyle);
            this.Controls.Add(this.loadingCircleMacOSX);
            this.Controls.Add(this.lblIE7Style);
            this.Controls.Add(this.loadingCircleIE7);
            this.Controls.Add(this.lblFireFox);
            this.Controls.Add(this.loadingCircleFF);
            this.Controls.Add(this.lblCustomizable);
            this.Controls.Add(this.btnIE7Style);
            this.Controls.Add(this.lblRotationSpeed);
            this.Controls.Add(this.nudRotationSpeed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lnkMartinGagne);
            this.Controls.Add(this.lblLoadingCircle);
            this.Controls.Add(this.loadingCircle);
            this.Controls.Add(this.btnFireFoxStyle);
            this.Controls.Add(this.btnMacOSXStyle);
            this.Controls.Add(this.cbColors);
            this.Controls.Add(this.nudSpokesThickness);
            this.Controls.Add(this.lblSpokeThickness);
            this.Controls.Add(this.nudNumberSpoke);
            this.Controls.Add(this.lblNumberSpoke);
            this.Controls.Add(this.lblInnerCircleRadius);
            this.Controls.Add(this.nudInnerCircleRadius);
            this.Controls.Add(this.lblOuterCircleRadius);
            this.Controls.Add(this.nudOuterCircleRadius);
            this.Controls.Add(this.btnDesactivate);
            this.Controls.Add(this.btnActivate);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudOuterCircleRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInnerCircleRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberSpoke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpokesThickness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRotationSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private LoadingCircle loadingCircle;
        private System.Windows.Forms.Button btnActivate;
        private System.Windows.Forms.Button btnDesactivate;
        private System.Windows.Forms.NumericUpDown nudOuterCircleRadius;
        private System.Windows.Forms.Label lblOuterCircleRadius;
        private System.Windows.Forms.Label lblInnerCircleRadius;
        private System.Windows.Forms.NumericUpDown nudInnerCircleRadius;
        private System.Windows.Forms.Label lblNumberSpoke;
        private System.Windows.Forms.NumericUpDown nudNumberSpoke;
        private System.Windows.Forms.NumericUpDown nudSpokesThickness;
        private System.Windows.Forms.Label lblSpokeThickness;
        private System.Windows.Forms.ComboBox cbColors;
        private System.Windows.Forms.Button btnMacOSXStyle;
        private System.Windows.Forms.Button btnFireFoxStyle;
        private LoadingCircle loadingCircle;
        private System.Windows.Forms.Label lblLoadingCircle;
        private System.Windows.Forms.LinkLabel lnkMartinGagne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRotationSpeed;
        private System.Windows.Forms.NumericUpDown nudRotationSpeed;
        private System.Windows.Forms.Button btnIE7Style;
        private System.Windows.Forms.Label lblCustomizable;
        private System.Windows.Forms.Label lblFireFox;
        private LoadingCircle loadingCircleFF;
        private System.Windows.Forms.Label lblIE7Style;
        private LoadingCircle loadingCircleIE7;
        private System.Windows.Forms.Label lblMacOSXStyle;
        private LoadingCircle loadingCircleMacOSX;
        private System.Windows.Forms.LinkLabel linkLabel1;

    }
}

