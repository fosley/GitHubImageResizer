
namespace GitHubImageString
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txtImageBB = new System.Windows.Forms.TextBox();
            this.lblImageBB = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblImageHTML = new System.Windows.Forms.Label();
            this.txtImageHTML = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.chkAutoCopy = new System.Windows.Forms.CheckBox();
            this.ttpMain = new System.Windows.Forms.ToolTip(this.components);
            this.chkAutoConvert = new System.Windows.Forms.CheckBox();
            this.chkAutoDelete = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtImageBB
            // 
            this.txtImageBB.Location = new System.Drawing.Point(15, 201);
            this.txtImageBB.Name = "txtImageBB";
            this.txtImageBB.Size = new System.Drawing.Size(303, 20);
            this.txtImageBB.TabIndex = 0;
            this.txtImageBB.Text = "![Step m04](https://user-images.githubusercontent.com/44016699/155633405-0903576b" +
    "-4def-4d61-8635-bc6a4ce75904.png)";
            this.txtImageBB.TextChanged += new System.EventHandler(this.txtImageBB_TextChanged);
            // 
            // lblImageBB
            // 
            this.lblImageBB.AutoSize = true;
            this.lblImageBB.Location = new System.Drawing.Point(12, 185);
            this.lblImageBB.Name = "lblImageBB";
            this.lblImageBB.Size = new System.Drawing.Size(118, 13);
            this.lblImageBB.TabIndex = 1;
            this.lblImageBB.Text = "Image string (BB Code):";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(12, 224);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(38, 13);
            this.lblWidth.TabIndex = 3;
            this.lblWidth.Text = "Width:";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(15, 240);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(303, 20);
            this.txtWidth.TabIndex = 2;
            this.txtWidth.Text = "50%";
            this.txtWidth.TextChanged += new System.EventHandler(this.txtWidth_TextChanged);
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(12, 263);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(41, 13);
            this.lblHeight.TabIndex = 5;
            this.lblHeight.Text = "Height:";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(15, 279);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(303, 20);
            this.txtHeight.TabIndex = 4;
            this.txtHeight.Text = "50%";
            this.txtHeight.TextChanged += new System.EventHandler(this.txtHeight_TextChanged);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(15, 305);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 6;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblImageHTML
            // 
            this.lblImageHTML.AutoSize = true;
            this.lblImageHTML.Location = new System.Drawing.Point(12, 349);
            this.lblImageHTML.Name = "lblImageHTML";
            this.lblImageHTML.Size = new System.Drawing.Size(106, 13);
            this.lblImageHTML.TabIndex = 8;
            this.lblImageHTML.Text = "Image string (HTML):";
            // 
            // txtImageHTML
            // 
            this.txtImageHTML.Location = new System.Drawing.Point(15, 365);
            this.txtImageHTML.Name = "txtImageHTML";
            this.txtImageHTML.ReadOnly = true;
            this.txtImageHTML.Size = new System.Drawing.Size(303, 20);
            this.txtImageHTML.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 156);
            this.label1.TabIndex = 9;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(106, 305);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 8;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // chkAutoCopy
            // 
            this.chkAutoCopy.AutoSize = true;
            this.chkAutoCopy.Checked = true;
            this.chkAutoCopy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoCopy.Location = new System.Drawing.Point(106, 329);
            this.chkAutoCopy.Name = "chkAutoCopy";
            this.chkAutoCopy.Size = new System.Drawing.Size(75, 17);
            this.chkAutoCopy.TabIndex = 12;
            this.chkAutoCopy.Text = "Auto Copy";
            this.ttpMain.SetToolTip(this.chkAutoCopy, "If checked, clicking Convert will automatically copy the output to your clipboard" +
        ".");
            this.chkAutoCopy.UseVisualStyleBackColor = true;
            // 
            // chkAutoConvert
            // 
            this.chkAutoConvert.AutoSize = true;
            this.chkAutoConvert.Checked = true;
            this.chkAutoConvert.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoConvert.Location = new System.Drawing.Point(15, 329);
            this.chkAutoConvert.Name = "chkAutoConvert";
            this.chkAutoConvert.Size = new System.Drawing.Size(88, 17);
            this.chkAutoConvert.TabIndex = 10;
            this.chkAutoConvert.Text = "Auto Convert";
            this.ttpMain.SetToolTip(this.chkAutoConvert, "If checked, typing or pasting in the BB code textbox will\r\nautomatically attempt " +
        "to convert the string as it\'s typed.");
            this.chkAutoConvert.UseVisualStyleBackColor = true;
            // 
            // chkAutoDelete
            // 
            this.chkAutoDelete.AutoSize = true;
            this.chkAutoDelete.Checked = true;
            this.chkAutoDelete.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoDelete.Location = new System.Drawing.Point(187, 329);
            this.chkAutoDelete.Name = "chkAutoDelete";
            this.chkAutoDelete.Size = new System.Drawing.Size(82, 17);
            this.chkAutoDelete.TabIndex = 15;
            this.chkAutoDelete.Text = "Auto Delete";
            this.ttpMain.SetToolTip(this.chkAutoDelete, "If checked, the BBCode will be deleted from the textbox\r\nany time a valid convers" +
        "ion happens. Not good for\r\ntyping things manually, but makes it faster for pasti" +
        "ng\r\nentire strings at a time.");
            this.chkAutoDelete.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 396);
            this.Controls.Add(this.chkAutoDelete);
            this.Controls.Add(this.chkAutoConvert);
            this.Controls.Add(this.chkAutoCopy);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblImageHTML);
            this.Controls.Add(this.txtImageHTML);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.lblImageBB);
            this.Controls.Add(this.txtImageBB);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GitHub Image Resizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtImageBB;
        private System.Windows.Forms.Label lblImageBB;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblImageHTML;
        private System.Windows.Forms.TextBox txtImageHTML;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.CheckBox chkAutoCopy;
        private System.Windows.Forms.ToolTip ttpMain;
        private System.Windows.Forms.CheckBox chkAutoConvert;
        private System.Windows.Forms.CheckBox chkAutoDelete;
    }
}

