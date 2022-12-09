namespace Organizer
{
    partial class Sudoku
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.newGameButton = new System.Windows.Forms.Button();
            this.checkButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.EasyLevel = new System.Windows.Forms.RadioButton();
            this.MediumLevel = new System.Windows.Forms.RadioButton();
            this.HardLevel = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(51, 49);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 409);
            this.panel1.TabIndex = 0;
            // 
            // newGameButton
            // 
            this.newGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGameButton.Location = new System.Drawing.Point(480, 200);
            this.newGameButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(119, 30);
            this.newGameButton.TabIndex = 1;
            this.newGameButton.Text = "Новая игра";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // checkButton
            // 
            this.checkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkButton.Location = new System.Drawing.Point(480, 240);
            this.checkButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(119, 30);
            this.checkButton.TabIndex = 2;
            this.checkButton.Text = "Проверить";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(480, 280);
            this.clearButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(119, 30);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // EasyLevel
            // 
            this.EasyLevel.AutoSize = true;
            this.EasyLevel.Checked = true;
            this.EasyLevel.Location = new System.Drawing.Point(485, 98);
            this.EasyLevel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EasyLevel.Name = "EasyLevel";
            this.EasyLevel.Size = new System.Drawing.Size(62, 17);
            this.EasyLevel.TabIndex = 3;
            this.EasyLevel.TabStop = true;
            this.EasyLevel.Text = "Лёгкий";
            this.EasyLevel.UseVisualStyleBackColor = true;
            // 
            // MediumLevel
            // 
            this.MediumLevel.AutoSize = true;
            this.MediumLevel.Location = new System.Drawing.Point(485, 128);
            this.MediumLevel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MediumLevel.Name = "MediumLevel";
            this.MediumLevel.Size = new System.Drawing.Size(68, 17);
            this.MediumLevel.TabIndex = 3;
            this.MediumLevel.Text = "Средний";
            this.MediumLevel.UseVisualStyleBackColor = true;
            // 
            // HardLevel
            // 
            this.HardLevel.AutoSize = true;
            this.HardLevel.Location = new System.Drawing.Point(485, 164);
            this.HardLevel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HardLevel.Name = "HardLevel";
            this.HardLevel.Size = new System.Drawing.Size(72, 17);
            this.HardLevel.TabIndex = 3;
            this.HardLevel.Text = "Сложный";
            this.HardLevel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(475, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Выберите уровень сложности:";
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Exit.Location = new System.Drawing.Point(480, 320);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(119, 30);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Выйти";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 487);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HardLevel);
            this.Controls.Add(this.MediumLevel);
            this.Controls.Add(this.EasyLevel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Судоку by Герман Трошин";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.RadioButton EasyLevel;
        private System.Windows.Forms.RadioButton MediumLevel;
        private System.Windows.Forms.RadioButton HardLevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exit;
    }
}

