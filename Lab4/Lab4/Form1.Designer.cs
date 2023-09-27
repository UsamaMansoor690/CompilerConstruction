namespace Lab4
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
            this.input_box = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btn = new System.Windows.Forms.Button();
            this.activity = new System.Windows.Forms.Button();
            this.tfInput = new System.Windows.Forms.TextBox();
            this.tfTokens = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.clear__btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // input_box
            // 
            this.input_box.Location = new System.Drawing.Point(13, 48);
            this.input_box.Multiline = true;
            this.input_box.Name = "input_box";
            this.input_box.Size = new System.Drawing.Size(513, 56);
            this.input_box.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(13, 163);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(512, 269);
            this.dataGridView.TabIndex = 2;
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.Location = new System.Drawing.Point(11, 448);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(513, 59);
            this.btn.TabIndex = 3;
            this.btn.Text = "Analyze (Lab Task)";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // activity
            // 
            this.activity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activity.Location = new System.Drawing.Point(657, 444);
            this.activity.Name = "activity";
            this.activity.Size = new System.Drawing.Size(239, 63);
            this.activity.TabIndex = 4;
            this.activity.Text = "Lab Activity";
            this.activity.UseVisualStyleBackColor = true;
            this.activity.Click += new System.EventHandler(this.activity_Click);
            // 
            // tfInput
            // 
            this.tfInput.Location = new System.Drawing.Point(657, 48);
            this.tfInput.Multiline = true;
            this.tfInput.Name = "tfInput";
            this.tfInput.Size = new System.Drawing.Size(503, 56);
            this.tfInput.TabIndex = 5;
            // 
            // tfTokens
            // 
            this.tfTokens.Location = new System.Drawing.Point(657, 176);
            this.tfTokens.Name = "tfTokens";
            this.tfTokens.Size = new System.Drawing.Size(503, 256);
            this.tfTokens.TabIndex = 6;
            this.tfTokens.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lab Task";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(654, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Lab Activity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Input Box";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(655, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Input Box";
            // 
            // clear__btn
            // 
            this.clear__btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear__btn.Location = new System.Drawing.Point(921, 444);
            this.clear__btn.Name = "clear__btn";
            this.clear__btn.Size = new System.Drawing.Size(239, 63);
            this.clear__btn.TabIndex = 11;
            this.clear__btn.Text = "Clear Button";
            this.clear__btn.UseVisualStyleBackColor = true;
            this.clear__btn.Click += new System.EventHandler(this.clear__btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 519);
            this.Controls.Add(this.clear__btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tfTokens);
            this.Controls.Add(this.tfInput);
            this.Controls.Add(this.activity);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.input_box);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_box;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button activity;
        private System.Windows.Forms.TextBox tfInput;
        private System.Windows.Forms.RichTextBox tfTokens;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button clear__btn;
    }
}

