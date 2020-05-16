using QLKS.DAO;
using QLKS.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class fTableManager : Form
    {
        public fTableManager()
        {
            InitializeComponent();
            LoadRoom();
        }
        #region method
        void LoadRoom()
        {
            //lsvBill.Items.Clear();
            List<Room> roomList = RoomDAO.Instance.LoadRoomList();
            foreach(Room item in roomList)
            {
                Button btn = new Button() { Width = RoomDAO.RoomWith, Height = RoomDAO.RoomHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += Btn_Click;
                btn.Tag = item;
                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.LightGreen;
                        break;
                }

                flpRoom.Controls.Add(btn);
            }

            ShowBill(1);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            int idRoom = ((sender as Button).Tag as Room).Id;
            //int idRoom
            //MessageBox.Show(idRoom.ToString());
           // lsvBill.Tag = (sender as Button).Tag;
            ShowBill(idRoom);
        }

        void ShowBill(int id)
        {
            List<Bill> listBill = BillDAO.Instance.GetListBill(PhieuDangKyDAO.Instance.GetUncheckPhieuDKByRoomID(id));
            dgvBill.DataSource = listBill;
            dgvBill.Columns[0].HeaderText = "ID";
            dgvBill.Columns[1].HeaderText = "ID Phiếu đăng ký";
            dgvBill.Columns[2].HeaderText = "ID Service";
            dgvBill.Columns[3].HeaderText = "Tổng";
            dgvBill.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvBill.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvBill.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvBill.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvBill.RowHeadersVisible = false;
        }

        #endregion
        #region event
        private void btnAddSevice_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void flpRoom_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fTableManager_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lsvBill_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
