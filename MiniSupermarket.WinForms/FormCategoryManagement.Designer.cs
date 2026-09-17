namespace MiniSupermarket.WinForms
{
    partial class FormCategoryManagement
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnLoad;

        private System.Windows.Forms.GroupBox groupBoxList;
        private System.Windows.Forms.DataGridView dgvCategories;

        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;

        private System.Windows.Forms.GroupBox groupBoxInfo;

        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox txtId;

        private System.Windows.Forms.Label labelCategoryName;
        private System.Windows.Forms.TextBox txtCategoryName;

        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox txtDescription;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;

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
            this.components = new System.ComponentModel.Container();

            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();

            this.groupBoxList = new System.Windows.Forms.GroupBox();
            this.dgvCategories = new System.Windows.Forms.DataGridView();

            this.CategoryId =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.CategoryName =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.Description =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.groupBoxInfo = new System.Windows.Forms.GroupBox();

            this.labelId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();

            this.labelCategoryName = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();

            this.labelDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();

            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();

            this.statusStrip1 = new System.Windows.Forms.StatusStrip();

            this.toolStripStatusLabel1 =
                new System.Windows.Forms.ToolStripStatusLabel();

            this.toolStripStatusLabel2 =
                new System.Windows.Forms.ToolStripStatusLabel();

            this.groupBoxSearch.SuspendLayout();
            this.groupBoxList.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvCategories)).BeginInit();

            this.groupBoxInfo.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();

            // =====================================================
            // FORM
            // =====================================================

            this.AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(900, 520);

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "Quản lý Danh mục Nhóm hàng";

            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.groupBoxList);
            this.Controls.Add(this.groupBoxSearch);

            this.Name =
                "FormCategoryManagement";

            this.Load +=
                new System.EventHandler(
                    this.FormCategoryManagement_Load);

            // =====================================================
            // GROUPBOX TÌM KIẾM
            // =====================================================

            this.groupBoxSearch.Location =
                new System.Drawing.Point(10, 8);

            this.groupBoxSearch.Name =
                "groupBoxSearch";

            this.groupBoxSearch.Size =
                new System.Drawing.Size(875, 55);

            this.groupBoxSearch.TabIndex = 0;

            this.groupBoxSearch.TabStop = false;

            this.groupBoxSearch.Text =
                "Tìm kiếm";

            this.groupBoxSearch.Controls.Add(
                this.txtKeyword);

            this.groupBoxSearch.Controls.Add(
                this.btnSearch);

            this.groupBoxSearch.Controls.Add(
                this.btnLoad);

            // =====================================================
            // TEXTBOX TÌM KIẾM
            // =====================================================

            this.txtKeyword.Location =
                new System.Drawing.Point(15, 20);

            this.txtKeyword.Name =
                "txtKeyword";

            this.txtKeyword.Size =
                new System.Drawing.Size(315, 23);

            this.txtKeyword.TabIndex = 0;

            // giống ảnh mẫu
            this.txtKeyword.Text =
                "Nhập từ khóa...";

            // =====================================================
            // BUTTON TÌM KIẾM
            // =====================================================

            this.btnSearch.Location =
                new System.Drawing.Point(335, 18);

            this.btnSearch.Name =
                "btnSearch";

            this.btnSearch.Size =
                new System.Drawing.Size(80, 27);

            this.btnSearch.TabIndex = 1;

            this.btnSearch.Text =
                "Tìm kiếm";

            this.btnSearch.UseVisualStyleBackColor =
                true;

            this.btnSearch.Click +=
                new System.EventHandler(
                    this.btnSearch_Click);

            // =====================================================
            // BUTTON TẢI LẠI
            // =====================================================

            this.btnLoad.Location =
                new System.Drawing.Point(425, 18);

            this.btnLoad.Name =
                "btnLoad";

            this.btnLoad.Size =
                new System.Drawing.Size(75, 27);

            this.btnLoad.TabIndex = 2;

            this.btnLoad.Text =
                "Tải lại";

            this.btnLoad.UseVisualStyleBackColor =
                true;

            this.btnLoad.Click +=
                new System.EventHandler(
                    this.btnLoad_Click);

            // =====================================================
            // GROUPBOX DANH SÁCH
            // =====================================================

            this.groupBoxList.Location =
                new System.Drawing.Point(10, 70);

            this.groupBoxList.Name =
                "groupBoxList";

            this.groupBoxList.Size =
                new System.Drawing.Size(570, 420);

            this.groupBoxList.TabIndex = 1;

            this.groupBoxList.TabStop = false;

            this.groupBoxList.Text =
                "Danh sách Nhóm hàng";

            this.groupBoxList.Controls.Add(
                this.dgvCategories);

            // =====================================================
            // DATAGRIDVIEW
            // =====================================================

            this.dgvCategories.AllowUserToAddRows =
                false;

            this.dgvCategories.AllowUserToDeleteRows =
                false;

            this.dgvCategories.AllowUserToResizeRows =
                false;

            this.dgvCategories.AutoGenerateColumns =
                false;

            this.dgvCategories.BackgroundColor =
                System.Drawing.SystemColors.Window;

            this.dgvCategories.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.dgvCategories.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            this.dgvCategories.Columns.AddRange(
                new System.Windows.Forms.DataGridViewColumn[]
                {
                    this.CategoryId,
                    this.CategoryName,
                    this.Description
                });

            this.dgvCategories.Dock =
                System.Windows.Forms.DockStyle.Fill;

            this.dgvCategories.Location =
                new System.Drawing.Point(3, 19);

            this.dgvCategories.MultiSelect =
                false;

            this.dgvCategories.Name =
                "dgvCategories";

            this.dgvCategories.ReadOnly =
                true;

            this.dgvCategories.RowHeadersWidth =
                35;

            this.dgvCategories.RowTemplate.Height =
                25;

            this.dgvCategories.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgvCategories.Size =
                new System.Drawing.Size(564, 398);

            this.dgvCategories.TabIndex =
                0;

            this.dgvCategories.CellClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(
                    this.dgvCategories_CellClick);

            // =====================================================
            // CỘT MÃ ID
            // =====================================================

            this.CategoryId.DataPropertyName =
                "CategoryId";

            this.CategoryId.HeaderText =
                "Mã ID";

            // QUAN TRỌNG:
            // Name phải là CategoryId vì code cũ của bạn dùng:
            // row.Cells["CategoryId"]

            this.CategoryId.Name =
                "CategoryId";

            this.CategoryId.ReadOnly =
                true;

            this.CategoryId.Width =
                55;

            // =====================================================
            // CỘT TÊN NHÓM HÀNG
            // =====================================================

            this.CategoryName.DataPropertyName =
                "CategoryName";

            this.CategoryName.HeaderText =
                "Tên Nhóm hàng";

            // code cũ dùng:
            // row.Cells["CategoryName"]

            this.CategoryName.Name =
                "CategoryName";

            this.CategoryName.ReadOnly =
                true;

            this.CategoryName.Width =
                125;

            // =====================================================
            // CỘT MÔ TẢ
            // =====================================================

            this.Description.AutoSizeMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;

            this.Description.DataPropertyName =
                "Description";

            this.Description.HeaderText =
                "Mô Tả";

            // code cũ dùng:
            // row.Cells["Description"]

            this.Description.Name =
                "Description";

            this.Description.ReadOnly =
                true;

            // =====================================================
            // GROUPBOX THÔNG TIN
            // =====================================================

            this.groupBoxInfo.Location =
                new System.Drawing.Point(590, 70);

            this.groupBoxInfo.Name =
                "groupBoxInfo";

            this.groupBoxInfo.Size =
                new System.Drawing.Size(285, 420);

            this.groupBoxInfo.TabIndex =
                2;

            this.groupBoxInfo.TabStop =
                false;

            this.groupBoxInfo.Text =
                "Thông tin Nhóm hàng";

            this.groupBoxInfo.Controls.Add(
                this.labelId);

            this.groupBoxInfo.Controls.Add(
                this.txtId);

            this.groupBoxInfo.Controls.Add(
                this.labelCategoryName);

            this.groupBoxInfo.Controls.Add(
                this.txtCategoryName);

            this.groupBoxInfo.Controls.Add(
                this.labelDescription);

            this.groupBoxInfo.Controls.Add(
                this.txtDescription);

            this.groupBoxInfo.Controls.Add(
                this.btnAdd);

            this.groupBoxInfo.Controls.Add(
                this.btnUpdate);

            this.groupBoxInfo.Controls.Add(
                this.btnDelete);

            // =====================================================
            // LABEL MÃ ID
            // =====================================================

            this.labelId.AutoSize =
                true;

            this.labelId.Location =
                new System.Drawing.Point(12, 30);

            this.labelId.Name =
                "labelId";

            this.labelId.Size =
                new System.Drawing.Size(36, 15);

            this.labelId.TabIndex =
                0;

            this.labelId.Text =
                "Mã ID";

            // =====================================================
            // TEXTBOX ID
            // =====================================================

            this.txtId.Location =
                new System.Drawing.Point(12, 48);

            this.txtId.Name =
                "txtId";

            this.txtId.ReadOnly =
                true;

            this.txtId.Size =
                new System.Drawing.Size(258, 23);

            this.txtId.TabIndex =
                1;

            // =====================================================
            // LABEL TÊN NHÓM HÀNG
            // =====================================================

            this.labelCategoryName.AutoSize =
                true;

            this.labelCategoryName.Location =
                new System.Drawing.Point(12, 82);

            this.labelCategoryName.Name =
                "labelCategoryName";

            this.labelCategoryName.Size =
                new System.Drawing.Size(91, 15);

            this.labelCategoryName.TabIndex =
                2;

            this.labelCategoryName.Text =
                "Tên Nhóm hàng";

            // =====================================================
            // TEXTBOX TÊN NHÓM HÀNG
            // =====================================================

            this.txtCategoryName.Location =
                new System.Drawing.Point(12, 100);

            this.txtCategoryName.Name =
                "txtCategoryName";

            this.txtCategoryName.Size =
                new System.Drawing.Size(258, 23);

            this.txtCategoryName.TabIndex =
                3;

            // =====================================================
            // LABEL BẢN MÔ TẢ
            // =====================================================

            this.labelDescription.AutoSize =
                true;

            this.labelDescription.Location =
                new System.Drawing.Point(12, 135);

            this.labelDescription.Name =
                "labelDescription";

            this.labelDescription.Size =
                new System.Drawing.Size(52, 15);

            this.labelDescription.TabIndex =
                4;

            this.labelDescription.Text =
                "Bản mô tả";

            // =====================================================
            // TEXTBOX BẢN MÔ TẢ
            // =====================================================

            this.txtDescription.Location =
                new System.Drawing.Point(12, 153);

            this.txtDescription.Multiline =
                true;

            this.txtDescription.Name =
                "txtDescription";

            // KHÔNG CÓ THANH CUỘN
            this.txtDescription.ScrollBars =
                System.Windows.Forms.ScrollBars.None;

            this.txtDescription.Size =
                new System.Drawing.Size(258, 55);

            this.txtDescription.TabIndex =
                5;

            // =====================================================
            // BUTTON THÊM MỚI
            // =====================================================

            this.btnAdd.Location =
                new System.Drawing.Point(12, 225);

            this.btnAdd.Name =
                "btnAdd";

            this.btnAdd.Size =
                new System.Drawing.Size(75, 28);

            this.btnAdd.TabIndex =
                6;

            this.btnAdd.Text =
                "Thêm mới";

            this.btnAdd.UseVisualStyleBackColor =
                true;

            this.btnAdd.Click +=
                new System.EventHandler(
                    this.btnAdd_Click);

            // =====================================================
            // BUTTON CẬP NHẬT
            // =====================================================

            this.btnUpdate.Location =
                new System.Drawing.Point(93, 225);

            this.btnUpdate.Name =
                "btnUpdate";

            this.btnUpdate.Size =
                new System.Drawing.Size(75, 28);

            this.btnUpdate.TabIndex =
                7;

            this.btnUpdate.Text =
                "Cập nhật";

            this.btnUpdate.UseVisualStyleBackColor =
                true;

            this.btnUpdate.Click +=
                new System.EventHandler(
                    this.btnUpdate_Click);

            // =====================================================
            // BUTTON XÓA
            // =====================================================

            this.btnDelete.Location =
                new System.Drawing.Point(174, 225);

            this.btnDelete.Name =
                "btnDelete";

            this.btnDelete.Size =
                new System.Drawing.Size(65, 28);

            this.btnDelete.TabIndex =
                8;

            this.btnDelete.Text =
                "Xóa";

            this.btnDelete.UseVisualStyleBackColor =
                true;

            this.btnDelete.Click +=
                new System.EventHandler(
                    this.btnDelete_Click);

            // =====================================================
            // STATUS STRIP
            // =====================================================

            this.statusStrip1.Items.AddRange(
                new System.Windows.Forms.ToolStripItem[]
                {
                    this.toolStripStatusLabel1,
                    this.toolStripStatusLabel2
                });

            this.statusStrip1.Location =
                new System.Drawing.Point(0, 498);

            this.statusStrip1.Name =
                "statusStrip1";

            this.statusStrip1.Size =
                new System.Drawing.Size(900, 22);

            this.statusStrip1.TabIndex =
                3;

            // =====================================================
            // STATUS "READY"
            // =====================================================

            this.toolStripStatusLabel1.Name =
                "toolStripStatusLabel1";

            this.toolStripStatusLabel1.Size =
                new System.Drawing.Size(39, 17);

            this.toolStripStatusLabel1.Text =
                "Ready";

            // =====================================================
            // API URL
            // =====================================================

            this.toolStripStatusLabel2.Name =
                "toolStripStatusLabel2";

            this.toolStripStatusLabel2.Size =
                new System.Drawing.Size(250, 17);

            this.toolStripStatusLabel2.Text =
                "https://localhost:7123/api/categories";

            // =====================================================
            // FINISH
            // =====================================================

            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();

            this.groupBoxList.ResumeLayout(false);

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvCategories)).EndInit();

            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();

            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}