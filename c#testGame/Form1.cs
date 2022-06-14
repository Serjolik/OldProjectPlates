using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public int score = 0; //Текущие очки
        public int score_multiplier = 1; //Множитель получения очков
        public int random_value = 0; //Выбор рандомного положения генерируемой кнопки
        public int coverage = 0; //Начальный номер используемых кнопок (движение)
        public int timer_interval = 20; //Интервал по времени
        public int Background_color = 0; //цвет фона
        public int plates_color = 0; //цвет плиток

        static public int buttons_width = 57; //Ширина генерируемых кнопок
        static public int buttons_height = 20; //Высота генерируемых кнопок
        static public Size falling_buttons_size = new Size(buttons_width, buttons_height); //Размеры генерируемых кнопок
        static public int width_between_buttons = 4; //Расстояние между кнопками по ширине
        static public int Height_between_buttons = 100; //Расстояние между кнопками по Высоте
        static public int all_size = 150; //Общие размеры (Общее количество генерируемых кнопок,
                                          //так же от него зависит количество очков, необходимых для победы(size - 15))
        static public int Number_of_buttons = 10; //Количество играбельных кнопок на клавитуре
        static public int Left_indent = 8; //Изначальный отступ слева от экрана
        static public int start_y_coord_of_button_movement = -20; //Начальная координата по игрику, в которой мы спавним кнопки,
                                                                  //нужна, чтобы кнопки изначально появлялись за экраном
        static public int coverage_width = 5; //Охват количества используемых кнопок (движение)
        static public int timer_interval_step = 2; //Шаг изменения интервала от количества очков
        static public int acceleration_step = 5; //За сколько очков идёт ускорение
        static public int Y_keyboard_buttons = 338; // Координата по игрику у кнопок, которые на клавиатуре
                                                    // (для проверки равенства координат)
        static public int buttons_speed = 2; //Скорость падающих кнопок
        static public int Screen_border = 380; //Границы мини экрана, для проверки на то,
                                               //что кнопка вышла за координаты = поражение
        Color color = new Color();
        Color next_color = new Color();
        /*
         * Используются кнопки клавиатуры:
         * Q, W, E, R, T, Y, U, I, O, P;
         * По названиям:
         * Q_button
         * W_button
         * E_button
         * R_button
         * T_button
         * Y_button
         * U_button
         * I_button
         * O_button
         * P_button
         */

        public Button[] button = new Button[all_size];
        public int[] buttonId = new int[all_size]; //Хранит номер буквы на клавиатуре(слева направо)

        public Form1()
        {
            this.KeyPreview = true; //Для отключения звука нажатия кнопки в винде
            this.KeyDown += Form1_KeyDown;
            this.KeyUp += Form1_KeyUp;
            InitializeComponent();
            Random rnd = new Random(); //Создаём рандом по количеству кнопок
            textBox1.Enabled = false;
            Q_button.Enabled = false;
            W_button.Enabled = false;
            E_button.Enabled = false;
            R_button.Enabled = false;
            T_button.Enabled = false;
            Y_button.Enabled = false;
            U_button.Enabled = false;
            I_button.Enabled = false;
            O_button.Enabled = false;
            P_button.Enabled = false; //По умолчанию сделали наши кнопки не доступными
            for (int i = 0; i < all_size; i++) //Цикл создания кнопок и их местоположения
            {
                random_value = rnd.Next(0, Number_of_buttons); // Берём рандомный номер для кнопки
                button[i] = new Button(); //Генерируем кнопку
                button[i].Enabled = false; //Говорим, что она выключена
                button[i].FlatStyle = FlatStyle.Popup;
                if (i < coverage_width)
                {
                    //Первые {coverage width}(Несколько кнопок по ширине шага) создаются отдельно, чтобы начало было плавным
                    button[i].Location = new Point(Left_indent + random_value * buttons_width + random_value * width_between_buttons,
                        start_y_coord_of_button_movement - i * Height_between_buttons);
                }
                else
                {
                    //Остальные создаются сверху за экраном
                    button[i].Location = new Point(Left_indent + random_value * buttons_width + random_value * width_between_buttons,
                        start_y_coord_of_button_movement - coverage_width * Height_between_buttons);
                }
                buttonId[i] = random_value;
                button[i].Size = falling_buttons_size;
                this.Controls.Add(button[i]);
            }
            timer1.Interval = timer_interval;
            
        }

        void Form1_KeyUp(object sender, KeyEventArgs e) //После поднятия кнопки выключаем их видимость нажатия
        {
            if (e.KeyCode == Keys.Q)
            {
                Q_button.Visible = false;
            }
            else if (e.KeyCode == Keys.W)
            {
                W_button.Visible = false;
            }
            else if (e.KeyCode == Keys.E)
            {
                E_button.Visible = false;
            }
            else if (e.KeyCode == Keys.R)
            {
                R_button.Visible = false;
            }
            else if (e.KeyCode == Keys.T)
            {
                T_button.Visible = false;
            }
            else if (e.KeyCode == Keys.Y)
            {
                Y_button.Visible = false;
            }
            else if (e.KeyCode == Keys.U)
            {
                U_button.Visible = false;
            }
            else if (e.KeyCode == Keys.I)
            {
                I_button.Visible = false;
            }
            else if (e.KeyCode == Keys.O)
            {
                O_button.Visible = false;
            }
            else if (e.KeyCode == Keys.P)
            {
                P_button.Visible = false;
            }
        }

        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //Подсвечиваем какую кнопку нажали

            e.SuppressKeyPress = true;
            if (e.KeyCode == Keys.Q)
            {
                Q_button.Visible = true;
            }
            else if (e.KeyCode == Keys.W)
            {
                W_button.Visible = true;
            }
            else if (e.KeyCode == Keys.E)
            {
                E_button.Visible = true;
            }
            else if (e.KeyCode == Keys.R)
            {
                R_button.Visible = true;
            }
            else if (e.KeyCode == Keys.T)
            {
                T_button.Visible = true;
            }
            else if (e.KeyCode == Keys.Y)
            {
                Y_button.Visible = true;
            }
            else if (e.KeyCode == Keys.U)
            {
                U_button.Visible = true;
            }
            else if (e.KeyCode == Keys.I)
            {
                I_button.Visible = true;
            }
            else if (e.KeyCode == Keys.O)
            {
                O_button.Visible = true;
            }
            else if (e.KeyCode == Keys.P)
            {
                P_button.Visible = true;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //При нажатии Старт, убираем эту кнопку,
            //отключаем нижнюю панель,
            //пишем, что очков пока 0 и запускаем таймер

            Start.Enabled = false;
            Start.Visible = false;
            Q_button.Visible = false;
            W_button.Visible = false;
            E_button.Visible = false;
            R_button.Visible = false;
            T_button.Visible = false;
            Y_button.Visible = false;
            U_button.Visible = false;
            I_button.Visible = false;
            O_button.Visible = false;
            P_button.Visible = false;
            Background_color_button.Visible = false;
            plates_color_button.Visible = false;
            textBox1.Text = "Баллы: " + score.ToString();
            timer1.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PlusPoint(int i)
        {
            //функция срабатывает, если мы нажали на падающую кнопку

            button[i].Visible = false;
            coverage++;
            score = score + score_multiplier;
            textBox1.Text = "Баллы: " + score.ToString();
            if ((score / score_multiplier) % acceleration_step == 0)
            {
                if (timer1.Interval > 10){
                    timer1.Interval -= timer_interval_step;
                }
            }
        }
        private void EndGame(int chet)
        {
            //Функция нормально выводит MessageBox при поражении

            string points_last = "очков";
            if (chet < 20)
            {
                switch (chet)
                {
                    case 1:
                        points_last = "очко";
                        break;
                    case 2:
                        points_last = "очка";
                        break;
                    case 3:
                        points_last = "очка";
                        break;
                    case 4:
                        points_last = "очка";
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (chet % 10)
                {
                    case 1:
                        points_last = "очко";
                        break;
                    case 2:
                        points_last = "очка";
                        break;
                    case 3:
                        points_last = "очка";
                        break;
                    case 4:
                        points_last = "очка";
                        break;
                    default:
                        break;
                }
            }
            string result_string = "Вы заработали: " + chet + " " + points_last;
            timer1.Enabled = false;
            DialogResult dialog = MessageBox.Show(
                result_string,
                "Игра окончена",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            if (dialog == DialogResult.OK)
            {
                this.Close();
            }
        }
        private void WinGame(int chet)
        {
            //Функция нормально выводит MessageBox при победе

            string result_string = "Поздравляем вы заработали: " + chet + "Очков";
            timer1.Enabled = false;
            DialogResult dialog = MessageBox.Show(
                result_string,
                "Победа",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            if (dialog == DialogResult.OK)
            {
                this.Close();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (score != all_size - 15)
            {
                for (int i = coverage; i < coverage_width + coverage; i++) //Движение только этих кнопок
                {
                    button[i].Location = new Point(button[i].Location.X,
                        button[i].Location.Y + buttons_speed);
                    if (button[i].Location.Y == Y_keyboard_buttons && button[i].Visible == true) //Если совпали координаты
                    {
                        switch (buttonId[i]) //Начисление очков если кнопка нажата
                        {
                            case 0:
                                if (Q_button.Visible == true)
                                {
                                    PlusPoint(i);
                                }
                                break;
                            case 1:
                                if (W_button.Visible == true)
                                {
                                    PlusPoint(i);
                                }
                                break;
                            case 2:
                                if (E_button.Visible == true)
                                {
                                    PlusPoint(i);
                                }
                                break;
                            case 3:
                                if (R_button.Visible == true)
                                {
                                    PlusPoint(i);
                                }
                                break;
                            case 4:
                                if (T_button.Visible == true)
                                {
                                    PlusPoint(i);
                                }
                                break;
                            case 5:
                                if (Y_button.Visible == true)
                                {
                                    PlusPoint(i);
                                }
                                break;
                            case 6:
                                if (U_button.Visible == true)
                                {
                                    PlusPoint(i);
                                }
                                break;
                            case 7:
                                if (I_button.Visible == true)
                                {
                                    PlusPoint(i);
                                }
                                break;
                            case 8:
                                if (O_button.Visible == true)
                                {
                                    PlusPoint(i);
                                }
                                break;
                            case 9:
                                if (P_button.Visible == true)
                                {
                                    PlusPoint(i);
                                }
                                break;
                            default:
                                break;
                        }
                    }
                    else if (button[i].Location.Y > Screen_border && button[i].Visible == true) //Поражение если кнопка пропущена
                    {
                        EndGame(score);
                    }
                }
            }
            else //Победа если осталось 15 до конца кнопок
            {
                WinGame(score);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void T_button_Click(object sender, EventArgs e)
        {

        }

        private void Y_button_Click(object sender, EventArgs e)
        {

        }

        private void U_button_Click(object sender, EventArgs e)
        {

        }

        private void I_button_Click(object sender, EventArgs e)
        {

        }

        private void O_button_Click(object sender, EventArgs e)
        {

        }

        private void P_button_Click(object sender, EventArgs e)
        {

        }

        private void Background_color_button_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.MidnightBlue;
            Background_color++;
            switch (Background_color % 5)
            {
                case 1:
                    Background_color_button.BackColor = Color.DarkViolet;
                    this.BackColor = Color.Turquoise;
                    break;
                case 2:
                    Background_color_button.BackColor = Color.LimeGreen;
                    this.BackColor = Color.DarkViolet;
                    break;
                case 3:
                    Background_color_button.BackColor = Color.DarkOrange;
                    this.BackColor = Color.LimeGreen;
                    break;
                case 4:
                    Background_color_button.BackColor = Color.White;
                    this.BackColor = Color.DarkOrange;
                    break;
                default:
                    Background_color_button.BackColor = Color.Turquoise;
                    this.BackColor = Color.White;
                    break;
            }
        }
        private void paint()
        {
            plates_color_button.BackColor = next_color;
            for (int i = 0; i < all_size; i++)
            {
                button[i].BackColor = color;
            }
            Start.BackColor = color;
            Q_button.BackColor = color;
            W_button.BackColor = color;
            E_button.BackColor = color;
            R_button.BackColor = color;
            T_button.BackColor = color;
            Y_button.BackColor = color;
            U_button.BackColor = color;
            I_button.BackColor = color;
            O_button.BackColor = color;
            P_button.BackColor = color;
        }

        private void plates_color_button_Click(object sender, EventArgs e)
        {
            plates_color++;
            switch (plates_color % 5)
            {
                case 1:
                    next_color = Color.DarkViolet;
                    color = Color.Turquoise;
                    break;
                case 2:
                    next_color = Color.LimeGreen;
                    color = Color.DarkViolet;
                    break;
                case 3:
                    next_color = Color.DarkOrange;
                    color = Color.LimeGreen;
                    break;
                case 4:
                    next_color = Color.White;
                    color = Color.DarkOrange;
                    break;
                default:
                    next_color = Color.Turquoise;
                    color = Color.White;
                    break;
            }
            paint();
        }
    }
}
