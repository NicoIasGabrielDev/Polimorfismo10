namespace Aula09Polimorfismo
{
    public class Jogador
    {
        public virtual void Chutar(){
            System.Console.WriteLine("Chuta normalmente");
        }
        public virtual void Driblar(){
            System.Console.WriteLine("Dribla normalmente");
        }
    }
}