namespace EnumeratedTypes
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
            this.btnVisaTypes = new System.Windows.Forms.Button();
            this.btnEnumIntegers = new System.Windows.Forms.Button();
            this.btnEnumVariables = new System.Windows.Forms.Button();
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnVisaTypes
            // 
            this.btnVisaTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisaTypes.Location = new System.Drawing.Point(7, 48);
            this.btnVisaTypes.Name = "btnVisaTypes";
            this.btnVisaTypes.Size = new System.Drawing.Size(165, 62);
            this.btnVisaTypes.TabIndex = 0;
            this.btnVisaTypes.Text = "Visa Types";
            this.btnVisaTypes.UseVisualStyleBackColor = true;
            this.btnVisaTypes.Click += new System.EventHandler(this.btnVisaTypes_Click);
            // 
            // btnEnumIntegers
            // 
            this.btnEnumIntegers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnumIntegers.Location = new System.Drawing.Point(226, 48);
            this.btnEnumIntegers.Name = "btnEnumIntegers";
            this.btnEnumIntegers.Size = new System.Drawing.Size(165, 62);
            this.btnEnumIntegers.TabIndex = 1;
            this.btnEnumIntegers.Text = "enumerators\r\nand Integers";
            this.btnEnumIntegers.UseVisualStyleBackColor = true;
            this.btnEnumIntegers.Click += new System.EventHandler(this.btnEnumIntegers_Click);
            // 
            // btnEnumVariables
            // 
            this.btnEnumVariables.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnumVariables.Location = new System.Drawing.Point(433, 48);
            this.btnEnumVariables.Name = "btnEnumVariables";
            this.btnEnumVariables.Size = new System.Drawing.Size(165, 62);
            this.btnEnumVariables.TabIndex = 2;
            this.btnEnumVariables.Text = "enum \r\nvariables";
            this.btnEnumVariables.UseVisualStyleBackColor = true;
            this.btnEnumVariables.Click += new System.EventHandler(this.btnEnumVariables_Click);
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.Location = new System.Drawing.Point(7, 134);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.Size = new System.Drawing.Size(591, 169);
            this.rtbDisplay.TabIndex = 3;
            this.rtbDisplay.Text = "";
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(7, 322);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(591, 56);
            this.txtDisplay.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 411);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.rtbDisplay);
            this.Controls.Add(this.btnEnumVariables);
            this.Controls.Add(this.btnEnumIntegers);
            this.Controls.Add(this.btnVisaTypes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVisaTypes;
        private System.Windows.Forms.Button btnEnumIntegers;
        private System.Windows.Forms.Button btnEnumVariables;
        private System.Windows.Forms.RichTextBox rtbDisplay;
        private System.Windows.Forms.TextBox txtDisplay;
    }
}

