namespace Lesson2
{
	partial class CarRent
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
            this.CarList = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.FromLabel = new System.Windows.Forms.Label();
            this.ToLabel = new System.Windows.Forms.Label();
            this.CarDescription = new System.Windows.Forms.RichTextBox();
            this.MakeAnOrderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CarList
            // 
            this.CarList.FormattingEnabled = true;
            this.CarList.Location = new System.Drawing.Point(13, 39);
            this.CarList.Name = "CarList";
            this.CarList.Size = new System.Drawing.Size(207, 316);
            this.CarList.TabIndex = 0;
            this.CarList.SelectedIndexChanged += new System.EventHandler(this.CarList_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(244, 62);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(244, 126);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 2;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromLabel.Location = new System.Drawing.Point(244, 39);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(46, 20);
            this.FromLabel.TabIndex = 3;
            this.FromLabel.Text = "From";
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToLabel.Location = new System.Drawing.Point(244, 100);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(27, 20);
            this.ToLabel.TabIndex = 4;
            this.ToLabel.Text = "To";
            // 
            // CarDescription
            // 
            this.CarDescription.Enabled = false;
            this.CarDescription.Location = new System.Drawing.Point(244, 176);
            this.CarDescription.Name = "CarDescription";
            this.CarDescription.Size = new System.Drawing.Size(200, 123);
            this.CarDescription.TabIndex = 5;
            this.CarDescription.Text = "";
            // 
            // MakeAnOrderButton
            // 
            this.MakeAnOrderButton.Location = new System.Drawing.Point(244, 331);
            this.MakeAnOrderButton.Name = "MakeAnOrderButton";
            this.MakeAnOrderButton.Size = new System.Drawing.Size(200, 23);
            this.MakeAnOrderButton.TabIndex = 6;
            this.MakeAnOrderButton.Text = "Make An Order";
            this.MakeAnOrderButton.UseVisualStyleBackColor = true;
            this.MakeAnOrderButton.Click += new System.EventHandler(this.MakeAnOrderButton_Click);
            // 
            // CarRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(456, 390);
            this.Controls.Add(this.MakeAnOrderButton);
            this.Controls.Add(this.CarDescription);
            this.Controls.Add(this.ToLabel);
            this.Controls.Add(this.FromLabel);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.CarList);
            this.Name = "CarRent";
            this.Text = "CarRent";
            this.Load += new System.EventHandler(this.CarRent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox CarList;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.Label FromLabel;
		private System.Windows.Forms.Label ToLabel;
		private System.Windows.Forms.RichTextBox CarDescription;
		private System.Windows.Forms.Button MakeAnOrderButton;
	}
}

