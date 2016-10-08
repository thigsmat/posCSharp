using PosDesignerPatternsFCV.FatoryMetod;
using PosDesignerPatternsFCV.FatoryMetod.Atividade_desafio;
using PosDesignerPatternsFCV.FatoryMetod.Atividade_desafio_II;
using PosDesignerPatternsFCV.Polimorfismo;
using PosDesignerPatternsFCV.Singleton;
using System;

namespace PosDesignerPatternsFCV
{
    class Program
    {
        static void Main(string[] args)
        {
            ConexaoSingleton c1 = ConexaoSingleton.GetConexao();
            ConexaoSingleton c2 = ConexaoSingleton.GetConexao();
            if (c1.Equals(c2))
            {
                Console.WriteLine("sim");
            }

            //   polimorfismo 
            Crepusculo cres = new Crepusculo();
            StarWars srw = new StarWars();
            Cinema cin = new Cinema();
            cin.EntrarNoCinema(srw);
            cin.EntrarNoCinema(cres);

            //Factory Method 1
            MotoFactory fab = new MotoFactory();
            MotoNinja c = (MotoNinja)fab.FabricarMotos(EMotos.NINJA);

            c.ExibirModelo();

            //Factory Method 2 fazendo as fabricas especificas
            Fabrica[] fabs = new Fabrica[4];
            fabs[0] = new FabricaBMW();
            fabs[1] = new FabricaHonda();
            fabs[2] = new FabricaNinja();
            fabs[3] = new FabricaYBR();

            foreach (var fabF in fabs)
            {
                IMoto moto = fabF.FabricarMotos();
                Console.WriteLine("Criado {0}",moto.GetType().Name);
                moto.ExibirModelo();
            }

            Pizzaiolo pizzaiolo= new Pizzaiolo();
            Comida pizza = pizzaiolo.criaComida();
            pizzaiolo.cozinhar();

            Churrasqueiro churras = new Churrasqueiro();
            Comida carne = churras.criaComida();
            churras.cozinhar();

            var veicu = new ConcreteVeiculoFactory().GetVeiculo("bike");
            veicu.Dirigir();
            veicu = new ConcreteVeiculoFactory().GetVeiculo("scooter");
            veicu.Dirigir();
        }
    }
}
