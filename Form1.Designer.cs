namespace Lab1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label2 = new Label();
            saveBuildButton = new Button();
            label1 = new Label();
            cpuCB = new ComboBox();
            label3 = new Label();
            motherboardCB = new ComboBox();
            label4 = new Label();
            caseCB = new ComboBox();
            label5 = new Label();
            gpuCB = new ComboBox();
            label6 = new Label();
            coolerCB = new ComboBox();
            label7 = new Label();
            ramCB = new ComboBox();
            label8 = new Label();
            dataCB = new ComboBox();
            label9 = new Label();
            powerCB = new ComboBox();
            label10 = new Label();
            label11 = new Label();
            totalSumLabel = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(5, 9);
            label2.Name = "label2";
            label2.Size = new Size(284, 45);
            label2.TabIndex = 2;
            label2.Text = "PC Builder v1.337";
            label2.Click += label2_Click;
            // 
            // saveBuildButton
            // 
            saveBuildButton.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            saveBuildButton.Location = new Point(12, 427);
            saveBuildButton.Name = "saveBuildButton";
            saveBuildButton.Size = new Size(254, 106);
            saveBuildButton.TabIndex = 17;
            saveBuildButton.Text = "СОХРАНИТЬ СБОРКУ";
            saveBuildButton.UseVisualStyleBackColor = true;
            saveBuildButton.Click += saveBuildButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(33, 102);
            label1.Name = "label1";
            label1.Size = new Size(120, 30);
            label1.TabIndex = 0;
            label1.Text = "Процессор";
            // 
            // cpuCB
            // 
            cpuCB.FormattingEnabled = true;
            cpuCB.Location = new Point(301, 109);
            cpuCB.Name = "cpuCB";
            cpuCB.Size = new Size(478, 23);
            cpuCB.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(33, 132);
            label3.Name = "label3";
            label3.Size = new Size(201, 30);
            label3.TabIndex = 3;
            label3.Text = "Материнская плата";
            // 
            // motherboardCB
            // 
            motherboardCB.FormattingEnabled = true;
            motherboardCB.Location = new Point(301, 139);
            motherboardCB.Name = "motherboardCB";
            motherboardCB.Size = new Size(478, 23);
            motherboardCB.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(33, 162);
            label4.Name = "label4";
            label4.Size = new Size(81, 30);
            label4.TabIndex = 5;
            label4.Text = "Корпус";
            // 
            // caseCB
            // 
            caseCB.FormattingEnabled = true;
            caseCB.Location = new Point(301, 168);
            caseCB.Name = "caseCB";
            caseCB.Size = new Size(478, 23);
            caseCB.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(33, 192);
            label5.Name = "label5";
            label5.Size = new Size(124, 30);
            label5.TabIndex = 7;
            label5.Text = "Видеокарта";
            // 
            // gpuCB
            // 
            gpuCB.FormattingEnabled = true;
            gpuCB.Location = new Point(301, 198);
            gpuCB.Name = "gpuCB";
            gpuCB.Size = new Size(478, 23);
            gpuCB.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(33, 222);
            label6.Name = "label6";
            label6.Size = new Size(255, 30);
            label6.TabIndex = 9;
            label6.Text = "Охлаждение процессора";
            // 
            // coolerCB
            // 
            coolerCB.FormattingEnabled = true;
            coolerCB.Location = new Point(301, 228);
            coolerCB.Name = "coolerCB";
            coolerCB.Size = new Size(478, 23);
            coolerCB.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(33, 252);
            label7.Name = "label7";
            label7.Size = new Size(216, 30);
            label7.TabIndex = 11;
            label7.Text = "Оперативная память";
            // 
            // ramCB
            // 
            ramCB.FormattingEnabled = true;
            ramCB.Location = new Point(301, 258);
            ramCB.Name = "ramCB";
            ramCB.Size = new Size(478, 23);
            ramCB.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(33, 282);
            label8.Name = "label8";
            label8.Size = new Size(183, 30);
            label8.TabIndex = 13;
            label8.Text = "Хранение данных";
            // 
            // dataCB
            // 
            dataCB.FormattingEnabled = true;
            dataCB.Location = new Point(301, 288);
            dataCB.Name = "dataCB";
            dataCB.Size = new Size(478, 23);
            dataCB.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label9.Location = new Point(33, 312);
            label9.Name = "label9";
            label9.Size = new Size(143, 30);
            label9.TabIndex = 15;
            label9.Text = "Блок питания";
            // 
            // powerCB
            // 
            powerCB.FormattingEnabled = true;
            powerCB.Location = new Point(301, 318);
            powerCB.Name = "powerCB";
            powerCB.Size = new Size(478, 23);
            powerCB.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label10.Location = new Point(12, 72);
            label10.Name = "label10";
            label10.Size = new Size(299, 30);
            label10.TabIndex = 18;
            label10.Text = "Выберите комплектующие:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label11.Location = new Point(12, 370);
            label11.Name = "label11";
            label11.Size = new Size(86, 30);
            label11.TabIndex = 19;
            label11.Text = "Сумма:";
            // 
            // totalSumLabel
            // 
            totalSumLabel.AutoSize = true;
            totalSumLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            totalSumLabel.Location = new Point(104, 370);
            totalSumLabel.Name = "totalSumLabel";
            totalSumLabel.Size = new Size(55, 30);
            totalSumLabel.TabIndex = 20;
            totalSumLabel.Text = "0,00";
            totalSumLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 557);
            Controls.Add(totalSumLabel);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(powerCB);
            Controls.Add(label9);
            Controls.Add(saveBuildButton);
            Controls.Add(dataCB);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(cpuCB);
            Controls.Add(ramCB);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(coolerCB);
            Controls.Add(motherboardCB);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(gpuCB);
            Controls.Add(caseCB);
            Controls.Add(label5);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "SaiTeR's PC Builder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button saveBuildButton;
        private Label label1;
        private ComboBox cpuCB;
        private Label label3;
        private ComboBox motherboardCB;
        private Label label4;
        private ComboBox caseCB;
        private Label label5;
        private ComboBox gpuCB;
        private Label label6;
        private ComboBox coolerCB;
        private Label label7;
        private ComboBox ramCB;
        private Label label8;
        private ComboBox dataCB;
        private Label label9;
        private ComboBox powerCB;
        private Label label10;
        private Label label11;
        private Label totalSumLabel;
    }
}
