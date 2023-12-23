namespace Greedy_Florist
{
	internal class Program
	{
		static void Main(string[] args)
		{
			try
			{

			
			Console.WriteLine("Enter Number of Flowers   ");
			int numberofFlowers = int.Parse(Console.ReadLine());

			Console.WriteLine("Enter  Number of Friends ");
			var numberOfFriends = int.Parse(Console.ReadLine());

			List<int> FlowersPrices = new List<int>();
			
			Console.WriteLine("Enter Costs of Flowers");


			for (int i = 0; i < numberofFlowers; i++)
			{
				FlowersPrices.Add(int.Parse(Console.ReadLine()));
			}

			FlowersPrices.Sort();

			FlowersPrices.Reverse();

			//// Cost = PriceOfFlowers * (Customer Previously Purchased + 1 )

			var costPerFriendArray = new int[numberOfFriends];
			var  PurchaseTimesPerFriendArray= new int[numberOfFriends];
			var purchasedflagArray = new int[numberofFlowers];




			for (int i = 0; i < purchasedflagArray.Length; i++)
			{

				if (purchasedflagArray[i] == 0)
				{

					for (int k = 0; k < PurchaseTimesPerFriendArray.Length; k++)
					{
						

						if ( k!=PurchaseTimesPerFriendArray.Length-1
							&& PurchaseTimesPerFriendArray[k] == PurchaseTimesPerFriendArray[k + 1]) {
							costPerFriendArray[k] = costPerFriendArray[k] + (FlowersPrices[i] * (PurchaseTimesPerFriendArray[k] + 1));

							purchasedflagArray[i]++;
							PurchaseTimesPerFriendArray[k]++;

						} else if (k==PurchaseTimesPerFriendArray.Length-1&& PurchaseTimesPerFriendArray[k] < PurchaseTimesPerFriendArray[k - 1])
						{
							costPerFriendArray[k] = costPerFriendArray[k] + (FlowersPrices[i] * (PurchaseTimesPerFriendArray[k] + 1));

							purchasedflagArray[i]++;
							PurchaseTimesPerFriendArray[k]++;
						}
						else
						{
							continue;

						}


						if (purchasedflagArray[i] > 0)
							break;

                    }
				
				
				
				}


			}
				int sum=0;
				Array.ForEach(costPerFriendArray, (val) =>sum+=val);

                Console.WriteLine("Final Cost Equals "+sum);


                Console.Read();

            }
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}


		}
	}
}