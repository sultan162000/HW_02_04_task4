using System;

namespace HW_02_04_task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Tel android = new Tel("Samsung",987654321);
            
        }
    }

    class Tel{
        public string name{get;set;}
        private int number;
        bool st = false;

        private int Number{
            get{
                return number;
            }
            set{
                
                int c = 0;
                for (int i = value; i>0; i /=10, c++);
                if(c==9){
                    number=value;
                    st = true;
                }
            }
        }
        public Tel(string names, int number){
            this.name = names;
            this.Number = number;
            startTel(st);
        }

        private void showInfo(){
            System.Console.WriteLine("-------------------------");
            System.Console.WriteLine($"Имя телефона: {name}");
            System.Console.WriteLine($"Номер телефона: {Number}");
            System.Console.WriteLine("-------------------------");
            System.Console.WriteLine();
        }

        public void startTel(bool sostayan){
            if(sostayan){
                while(sostayan)
                {
                    System.Console.WriteLine("Наш телефон умеет:\n"+
                    "1.Звонить\n"+
                    "2.Показать информацию о телефоне\n"+
                    "3.Выйти из системы");
                    System.Console.Write("Выберите нужную функцию: ");
                    
                    int x = int.Parse(Console.ReadLine());
                    switch (x)
                    {
                        case 1:
                        System.Console.WriteLine();
                        System.Console.Write("Введите номер: ");
                        int a = int.Parse(Console.ReadLine());
                        int cnt = 0;
                        for (int i = a; i > 0;  i /= 10,cnt++);
                        if(cnt==9){
                            System.Console.WriteLine("Звоним в номер: "+a);
                            System.Console.WriteLine("Телефон ещё бета)");
                        }
                        else System.Console.WriteLine("Неверный номер!");

                        System.Console.WriteLine();
                        break;
                        case 2:
                        showInfo();
                        break;
                        case 3:
                        sostayan = false;
                        break;
                        default:
                        System.Console.WriteLine("Неверная опция");
                        break;

                    }
                }

            }else{
                System.Console.Write("Неверный номер телефона!");
            }
        }

    }
}
