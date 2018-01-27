namespace _5semestr
{
    partial class formMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMenu));
            this.buttonText = new System.Windows.Forms.Button();
            this.buttonTheory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExample = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonText
            // 
            this.buttonText.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.buttonText, "buttonText");
            this.buttonText.Name = "buttonText";
            this.buttonText.UseVisualStyleBackColor = true;
            this.buttonText.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // buttonTheory
            // 
            this.buttonTheory.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.buttonTheory, "buttonTheory");
            this.buttonTheory.Name = "buttonTheory";
            this.buttonTheory.UseVisualStyleBackColor = true;
            this.buttonTheory.Click += new System.EventHandler(this.buttonTheory_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // buttonExample
            // 
            this.buttonExample.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.buttonExample, "buttonExample");
            this.buttonExample.Name = "buttonExample";
            this.buttonExample.UseVisualStyleBackColor = true;
            this.buttonExample.Click += new System.EventHandler(this.buttonExample_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.LightCoral;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.buttonExit, "buttonExit");
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click_1);
            // 
            // formMenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonExample);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTheory);
            this.Controls.Add(this.buttonText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonText;
        private System.Windows.Forms.Button buttonTheory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExample;
        private System.Windows.Forms.Button buttonExit;
    }
}

