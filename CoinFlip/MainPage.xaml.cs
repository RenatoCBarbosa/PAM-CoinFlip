
namespace CoinFlip
{
    class SorteioMoeda
    {
        public int lado { get; set; }

        public void GirarMoeda(int lado)
        {
            if (lado == 0)
            {
                //DisplayAlert("Resultado", "Você ganhou!", "Ok");
            }
            else if (lado == 1)
            { 
                //DisplayAlert("Resultado", "Você ganhou!", "Ok");
            }
        }
    }




    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        SorteioMoeda CoinFlip = new SorteioMoeda();

        private void FlipButton_Clicked(object sender, EventArgs e)
        {
            Random random = new Random();
            //Algoritmo
            //Verificar qual opção está selecionada
            //Fazer o sorteio da moeda
            //Exibir o lado que foi sorteado
            //Verificar se a opção == lado escolhido
            //Exibir o resultado em um alerta
            CoinFlip.lado = random.Next(2);
            switch (CoinFlip.lado)
            {
                case 0:
                    {
                        ImagemMoeda.Source = "coroaa.png";
                        CoinFlip.GirarMoeda(0);
                    }
                    break;

                case 1:
                    {
                        ImagemMoeda.Source = "caraa.png";
                        CoinFlip.GirarMoeda(1);
                    }
                    break;
            }

        }
    }
   
}

//Tirar o objeto coinflip e colocar esse código de baixo do switch case para voltar ao normal

/* if (PickerMoeda.SelectedItem.Equals("Cara") && this.valorSorteio == 1)
{
    DisplayAlert("Resultado", "Você ganhou!", "Ok");
}
else if (PickerMoeda.SelectedItem.Equals("Coroa") && this.valorSorteio == 0)
{
    DisplayAlert("Resultado", "Você ganhou!", "Ok");
}
*/