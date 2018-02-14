namespace CompositePattern
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
            this.btn_shortHike = new System.Windows.Forms.Button();
            this.btn_longHike = new System.Windows.Forms.Button();
            this.btn_army = new System.Windows.Forms.Button();
            this.txtBox_display = new System.Windows.Forms.RichTextBox();
            this.cmb_item = new System.Windows.Forms.ComboBox();
            this.btn_addItem = new System.Windows.Forms.Button();
            this.btn_removeItem = new System.Windows.Forms.Button();
            this.lbl_weight = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_shortHike
            // 
            this.btn_shortHike.Location = new System.Drawing.Point(18, 18);
            this.btn_shortHike.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_shortHike.Name = "btn_shortHike";
            this.btn_shortHike.Size = new System.Drawing.Size(183, 35);
            this.btn_shortHike.TabIndex = 1;
            this.btn_shortHike.Text = "Short Hike";
            this.btn_shortHike.UseVisualStyleBackColor = true;
            this.btn_shortHike.Click += new System.EventHandler(this.btn_shortHike_Click);
            // 
            // btn_longHike
            // 
            this.btn_longHike.Location = new System.Drawing.Point(18, 63);
            this.btn_longHike.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_longHike.Name = "btn_longHike";
            this.btn_longHike.Size = new System.Drawing.Size(183, 35);
            this.btn_longHike.TabIndex = 2;
            this.btn_longHike.Text = "Long Hike";
            this.btn_longHike.UseVisualStyleBackColor = true;
            this.btn_longHike.Click += new System.EventHandler(this.btn_longHike_Click);
            // 
            // btn_army
            // 
            this.btn_army.Location = new System.Drawing.Point(18, 111);
            this.btn_army.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_army.Name = "btn_army";
            this.btn_army.Size = new System.Drawing.Size(183, 35);
            this.btn_army.TabIndex = 3;
            this.btn_army.Text = "Forced March";
            this.btn_army.UseVisualStyleBackColor = true;
            this.btn_army.Click += new System.EventHandler(this.btn_army_Click);
            // 
            // txtBox_display
            // 
            this.txtBox_display.Location = new System.Drawing.Point(210, 18);
            this.txtBox_display.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBox_display.Name = "txtBox_display";
            this.txtBox_display.Size = new System.Drawing.Size(470, 304);
            this.txtBox_display.TabIndex = 4;
            this.txtBox_display.Text = "";
            // 
            // cmb_item
            // 
            this.cmb_item.FormattingEnabled = true;
            this.cmb_item.Items.AddRange(new object[] {
            "Water",
            "Survival Bar",
            "Tent Stake"});
            this.cmb_item.Location = new System.Drawing.Point(20, 155);
            this.cmb_item.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_item.Name = "cmb_item";
            this.cmb_item.Size = new System.Drawing.Size(180, 28);
            this.cmb_item.TabIndex = 6;
            // 
            // btn_addItem
            // 
            this.btn_addItem.Location = new System.Drawing.Point(20, 197);
            this.btn_addItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_addItem.Name = "btn_addItem";
            this.btn_addItem.Size = new System.Drawing.Size(182, 35);
            this.btn_addItem.TabIndex = 7;
            this.btn_addItem.Text = "Add";
            this.btn_addItem.UseVisualStyleBackColor = true;
            this.btn_addItem.Click += new System.EventHandler(this.btn_addItem_Click);
            // 
            // btn_removeItem
            // 
            this.btn_removeItem.Location = new System.Drawing.Point(20, 242);
            this.btn_removeItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_removeItem.Name = "btn_removeItem";
            this.btn_removeItem.Size = new System.Drawing.Size(183, 35);
            this.btn_removeItem.TabIndex = 8;
            this.btn_removeItem.Text = "Remove";
            this.btn_removeItem.UseVisualStyleBackColor = true;
            this.btn_removeItem.Click += new System.EventHandler(this.btn_removeItem_Click);
            // 
            // lbl_weight
            // 
            this.lbl_weight.AutoSize = true;
            this.lbl_weight.Location = new System.Drawing.Point(206, 327);
            this.lbl_weight.Name = "lbl_weight";
            this.lbl_weight.Size = new System.Drawing.Size(51, 20);
            this.lbl_weight.TabIndex = 9;
            this.lbl_weight.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 858);
            this.Controls.Add(this.lbl_weight);
            this.Controls.Add(this.btn_removeItem);
            this.Controls.Add(this.btn_addItem);
            this.Controls.Add(this.cmb_item);
            this.Controls.Add(this.txtBox_display);
            this.Controls.Add(this.btn_army);
            this.Controls.Add(this.btn_longHike);
            this.Controls.Add(this.btn_shortHike);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Composite Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_shortHike;
        private System.Windows.Forms.Button btn_longHike;
        private System.Windows.Forms.Button btn_army;
        private System.Windows.Forms.RichTextBox txtBox_display;
        private System.Windows.Forms.ComboBox cmb_item;
        private System.Windows.Forms.Button btn_addItem;
        private System.Windows.Forms.Button btn_removeItem;
        private System.Windows.Forms.Label lbl_weight;
    }
}

