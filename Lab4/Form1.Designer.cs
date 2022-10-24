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
            this.animals = new System.Windows.Forms.Button();
            this.birds = new System.Windows.Forms.Button();
            this.colors = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // animals
            // 
            this.animals.BackgroundImage = global::Lab4.Properties.Resources.icons8_animal_shelter_100;
            this.animals.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.animals.FlatAppearance.BorderColor = System.Drawing.Color.DarkMagenta;
            this.animals.FlatAppearance.BorderSize = 4;
            this.animals.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.animals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.animals.Font = new System.Drawing.Font("Pristina", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animals.Location = new System.Drawing.Point(197, 122);
            this.animals.Name = "animals";
            this.animals.Size = new System.Drawing.Size(107, 104);
            this.animals.TabIndex = 0;
            this.animals.UseVisualStyleBackColor = true;
            this.animals.Click += new System.EventHandler(this.animals_Click);
            // 
            // birds
            // 
            this.birds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.birds.BackgroundImage = global::Lab4.Properties.Resources.icons8_woodpecker_100;
            this.birds.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.birds.FlatAppearance.BorderColor = System.Drawing.Color.DarkMagenta;
            this.birds.FlatAppearance.BorderSize = 4;
            this.birds.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.birds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.birds.Font = new System.Drawing.Font("Pristina", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birds.Location = new System.Drawing.Point(369, 122);
            this.birds.Name = "birds";
            this.birds.Size = new System.Drawing.Size(107, 104);
            this.birds.TabIndex = 1;
            this.birds.UseVisualStyleBackColor = true;
            this.birds.Click += new System.EventHandler(this.birds_Click);
            // 
            // colors
            // 
            this.colors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colors.BackgroundImage = global::Lab4.Properties.Resources.icons8_paint_palette_100;
            this.colors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.colors.FlatAppearance.BorderColor = System.Drawing.Color.DarkMagenta;
            this.colors.FlatAppearance.BorderSize = 4;
            this.colors.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.colors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colors.Font = new System.Drawing.Font("Pristina", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colors.Location = new System.Drawing.Point(538, 122);
            this.colors.Name = "colors";
            this.colors.Size = new System.Drawing.Size(107, 104);
            this.colors.TabIndex = 2;
            this.colors.UseVisualStyleBackColor = true;
            this.colors.Click += new System.EventHandler(this.colors_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Pristina", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Animals";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Pristina", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(392, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Birds";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Pristina", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(560, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Colors";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Pristina", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(285, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(279, 45);
            this.label4.TabIndex = 6;
            this.label4.Text = "Let the learning begin!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lab4.Properties.Resources.empty_wooden_board_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(848, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.colors);
            this.Controls.Add(this.birds);
            this.Controls.Add(this.animals);
            this.Name = "Form1";
            this.Text = "Kids Learning ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button animals;
        private System.Windows.Forms.Button birds;
        private System.Windows.Forms.Button colors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

