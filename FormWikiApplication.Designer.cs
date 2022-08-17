﻿namespace WikiApplication
{
    partial class FormWikiApplication
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.listViewWiki = new System.Windows.Forms.ListView();
            this.textBoxDataStructureName = new System.Windows.Forms.TextBox();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.textBoxStructure = new System.Windows.Forms.TextBox();
            this.textBoxDefinition = new System.Windows.Forms.TextBox();
            this.labelDataStructureName = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelStructure = new System.Windows.Forms.Label();
            this.labelDefinition = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(257, 37);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonAdd_MouseClick);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(257, 66);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "EDIT";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonEdit_MouseClick);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(257, 95);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonDelete_MouseClick);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(257, 124);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonSave_MouseClick);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(257, 153);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 4;
            this.buttonLoad.Text = "LOAD";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonLoad_MouseClick);
            // 
            // listViewWiki
            // 
            this.listViewWiki.HideSelection = false;
            this.listViewWiki.Location = new System.Drawing.Point(338, 39);
            this.listViewWiki.Name = "listViewWiki";
            this.listViewWiki.Size = new System.Drawing.Size(450, 399);
            this.listViewWiki.TabIndex = 5;
            this.listViewWiki.UseCompatibleStateImageBehavior = false;
            this.listViewWiki.View = System.Windows.Forms.View.Details;
            // 
            // textBoxDataStructureName
            // 
            this.textBoxDataStructureName.Location = new System.Drawing.Point(128, 12);
            this.textBoxDataStructureName.Name = "textBoxDataStructureName";
            this.textBoxDataStructureName.Size = new System.Drawing.Size(123, 20);
            this.textBoxDataStructureName.TabIndex = 6;
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Location = new System.Drawing.Point(128, 39);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(123, 20);
            this.textBoxCategory.TabIndex = 7;
            // 
            // textBoxStructure
            // 
            this.textBoxStructure.Location = new System.Drawing.Point(128, 66);
            this.textBoxStructure.Name = "textBoxStructure";
            this.textBoxStructure.Size = new System.Drawing.Size(123, 20);
            this.textBoxStructure.TabIndex = 8;
            // 
            // textBoxDefinition
            // 
            this.textBoxDefinition.Location = new System.Drawing.Point(12, 112);
            this.textBoxDefinition.Multiline = true;
            this.textBoxDefinition.Name = "textBoxDefinition";
            this.textBoxDefinition.Size = new System.Drawing.Size(239, 326);
            this.textBoxDefinition.TabIndex = 9;
            // 
            // labelDataStructureName
            // 
            this.labelDataStructureName.AutoSize = true;
            this.labelDataStructureName.Location = new System.Drawing.Point(12, 15);
            this.labelDataStructureName.Name = "labelDataStructureName";
            this.labelDataStructureName.Size = new System.Drawing.Size(110, 13);
            this.labelDataStructureName.TabIndex = 10;
            this.labelDataStructureName.Text = "Data Structure Name:";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(12, 42);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(52, 13);
            this.labelCategory.TabIndex = 11;
            this.labelCategory.Text = "Category:";
            // 
            // labelStructure
            // 
            this.labelStructure.AutoSize = true;
            this.labelStructure.Location = new System.Drawing.Point(12, 69);
            this.labelStructure.Name = "labelStructure";
            this.labelStructure.Size = new System.Drawing.Size(53, 13);
            this.labelStructure.TabIndex = 12;
            this.labelStructure.Text = "Structure:";
            // 
            // labelDefinition
            // 
            this.labelDefinition.AutoSize = true;
            this.labelDefinition.Location = new System.Drawing.Point(12, 96);
            this.labelDefinition.Name = "labelDefinition";
            this.labelDefinition.Size = new System.Drawing.Size(54, 13);
            this.labelDefinition.TabIndex = 13;
            this.labelDefinition.Text = "Definition:";
            // 
            // FormWikiApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDefinition);
            this.Controls.Add(this.labelStructure);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelDataStructureName);
            this.Controls.Add(this.textBoxDefinition);
            this.Controls.Add(this.textBoxStructure);
            this.Controls.Add(this.textBoxCategory);
            this.Controls.Add(this.textBoxDataStructureName);
            this.Controls.Add(this.listViewWiki);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Name = "FormWikiApplication";
            this.Text = "Wiki Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.ListView listViewWiki;
        private System.Windows.Forms.TextBox textBoxDataStructureName;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.TextBox textBoxStructure;
        private System.Windows.Forms.TextBox textBoxDefinition;
        private System.Windows.Forms.Label labelDataStructureName;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelStructure;
        private System.Windows.Forms.Label labelDefinition;
    }
}

