using System.Collections.ObjectModel;

namespace SwipeIssue;

public partial class MainPage : ContentPage
{
    public class Fruit
    {
        public string FruitName { get; set; }
        public string FruitDescription { get; set; }
    }

    ObservableCollection<Fruit> fruits = new ObservableCollection<Fruit>();
    public ObservableCollection<Fruit> Fruits { get { return fruits; } }

    public MainPage()
	{
		InitializeComponent();

        fruits.Add(new Fruit() { FruitName = "Apple", FruitDescription = "An apple is an edible fruit produced by an apple tree (Malus domestica)." });
        fruits.Add(new Fruit() { FruitName = "Orange", FruitDescription = "The orange is the fruit of various citrus species in the family Rutaceae." });
        fruits.Add(new Fruit() { FruitName = "Banana", FruitDescription = "A long curved fruit with soft pulpy flesh and yellow skin when ripe." });
        fruits.Add(new Fruit() { FruitName = "Grape", FruitDescription = "A berry growing in clusters on a grapevine, eaten as fruit and used in making wine." });
        fruits.Add(new Fruit() { FruitName = "Mango", FruitDescription = "A mango is an edible stone fruit produced by the tropical tree Mangifera indica." });
        collectionView.ItemsSource = fruits;
    }
}


