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
                    
                }

            }else{
                System.Console.Write("Неверный номер телефона!");
            }
        }

    }
}
