

namespace ControleFuncionario
{
    
    class Funcionario
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public double Salary { get; private set; }


        public Funcionario(int id, string name, double salary) { 
            Id = id;
            Name = name;
            Salary = salary;
        }
        public void IncreaseSalary(double percentage)
        {
            Salary += ((Salary) * (percentage / 100));
        }

        public override string ToString()
        {
            return "ID: "+Id+"\n Nome: "+Name+"\n Salario: "+Salary;
        }
    }
   
   
}
