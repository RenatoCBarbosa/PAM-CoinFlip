
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
               // DisplayAlert("Resultado", "Você ganhou!", "Ok");
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
            //Algoritmo
            //Verificar qual opção está selecionada
            //Fazer o sorteio da moeda
            //Exibir o lado que foi sorteado
            //Verificar se a opção == lado escolhido
            //Exibir o resultado em um alerta

            Random random = new Random();
            CoinFlip.lado = random.Next(2);



            if (PickerMoeda.SelectedItem.Equals("Cara") && this.CoinFlip.lado == 0)
            {
                DisplayAlert("Resultado", "Você ganhou!", "Ok");
            }
            else if (PickerMoeda.SelectedItem.Equals("Coroa") && this.CoinFlip.lado == 1)
            {
                DisplayAlert("Resultado", "Você ganhou!", "Ok");
            }

            else
            {
                DisplayAlert("Resultado", "Você perdeu!", "Ok");
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