using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.ToolTips;
using GMap.NET.WindowsForms.Markers;

namespace SharpKML_Tutorial
{
    public partial class Form1 : Form
    {
        // чтобы перетаскивать форму без внешних панелей
        bool drag = false;
        Point start_point = new Point(0, 0);


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            pictureBoxLogo.BackColor = Color.Transparent;

            gMapControl1.Bearing = 0;
            gMapControl1.CanDragMap = true; //Открываем доступ к манипулированию картой мышью через зажатие правой кнопкой(по умолчанию).
            gMapControl1.DragButton = MouseButtons.Left; //Меняем кнопку манипулирования с правой кнопки(по умолчанию) на левую кнопку мыши.
            gMapControl1.GrayScaleMode = true;
            gMapControl1.MaxZoom = 14; //Устанавливаем максимальное приближение.
            gMapControl1.MinZoom = 2; //Устанавливаем минимальное приближение.
            gMapControl1.MouseWheelZoomType = MouseWheelZoomType.MousePositionAndCenter; //Устанавливаем центр приближения/удаления курсор мыши.

            gMapControl1.PolygonsEnabled = true; //Открываем отображение полигонов на карте.
            gMapControl1.MarkersEnabled = true; //Открываем отображение маркеров на карте.
            gMapControl1.NegativeMode = false; //Отказываемся от негативного режима
            gMapControl1.ShowTileGridLines = false; //Скрываем внешнюю сетку карты с заголовками
            gMapControl1.Dock = DockStyle.Fill; //Закрепляем контрол внутри формы, чтобы размеры контрола изменялись вместе с размером формы.
                                                //gMapControl1.MapProvider = GMapProviders.OpenStreetMap; //Указываем что будут использоваться карты OpenStreetMaps. Здесь куча карт на выбор.
            gMapControl1.MapProvider = GMapProviders.BingMap;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            //Если у вас используется прокси то вам нужны еще эти строки, описывать не буду, скажу только что параметры входа берутся из IE:
            //GMapProvider.WebProxy = System.Net.WebRequest.GetSystemWebProxy();
            //GMapProvider.WebProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;

            gMapControl1.Position = new GMap.NET.PointLatLng(54.997656, 82.695610); //Зададим стартовую позицию, я укажу "Красную площадь".
            GMapOverlay markersOverlay = new GMapOverlay(gMapControl1, "marker"); //Создадим коллекцию маркеров, указываем что имя коллекции "marker", а использоваться она будет в gMapControl1
            GMapMarkerGoogleGreen marker = new GMapMarkerGoogleGreen(new PointLatLng(54.997656, 82.695610)); //Создаем новый маркер.
            marker.ToolTip = new GMapRoundedToolTip(marker); //Создаем всплывающее окно
            marker.ToolTipText = "Дом"; //Задаем текст для всплывающего окна

            markersOverlay.Markers.Add(marker); //Добавляем маркер коллекцию.
            gMapControl1.Overlays.Add(markersOverlay); //Добавляем коллекцию в очередь на вывод на карту.

        }

        private void PictureExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PictureMinimizade_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PictureMaximizade_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            pictureMaximizar.Visible = true;
            pictureMaximizade.Visible = false;
        }

        private void PictureMaximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            pictureMaximizar.Visible = false;
            pictureMaximizade.Visible = true;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MenuSideBar_Click(object sender, EventArgs e)
        {
            if (panelSideBar.Width == 240)
            {
                sideBar.Visible = false;
                panelSideBar.Width = 55;
                sideBar.Width = 70;
                bunifuSeparator1.Width = 40;
                animationSideBar.Show(sideBar);
            }
            else
            {
                sideBar.Visible = false;
                panelSideBar.Width = 240;
                sideBar.Width = 225;
                bunifuSeparator1.Width = 217;
                animationSideBarBack.Show(sideBar);
            }
        }

        private void PanelTop_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true; // drag is your variable flag.
            start_point = new Point(e.X, e.Y);
        }

        private void PanelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void PanelTop_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            frmAddOnePointLocation frm = new frmAddOnePointLocation();
            frm.ShowDialog();
        }

        private void panelTop_DoubleClick(object sender, EventArgs e)
        {
            //if (MaximizeBox == true)
            //{
            //    this.WindowState = FormWindowState.Minimized;
            //}

            //else if (this.MaximizeBox == false)
            //{
            //    WindowState = FormWindowState. Maximized;
            //}
        }
    }

}
