namespace DIY2WinForm.Class
{
    public class CarList
    {
        public string Id { get; set; }
        public string Maker { get; set; }
        public string Model { get; set; }
        public int ProductionYear { get; set; }
        public string Color { get; set; }
        public string Country { get; set; }

        public CarList()
        {
        }

        public static List<CarList> PopulateCarList(List<CarMaker> carMakers, List<CarModel> carModels)
        {
            List<CarList> carList = new List<CarList>();

            foreach (CarMaker carMaker in carMakers)
            {
                foreach (CarModel carModel in carModels)
                {
                    if (carMaker.Id == carModel.CarMakerId)
                    {
                        CarList car = new CarList
                        {
                            Id = carModel.Id,
                            Maker = carMaker.Name,
                            Model = carModel.Model,
                            ProductionYear = carModel.ProductionYear,
                            Color = carModel.Color,
                            Country = carMaker.Country
                        };

                        carList.Add(car);
                    }
                }
            }

            return carList;
        }

        public static List<CarList> SearchCarList(List<CarList> carlist, string search)
        {
            if (string.IsNullOrEmpty(search))
                return carlist;

            search = search.ToLower();

            return carlist.Where(x => x.Maker.ToLower() == search ||
            x.Model.ToLower() == search ||
            x.Color.ToLower() == search ||
            x.ProductionYear.ToString().ToLower() == search ||
            x.Country.ToLower() == search).ToList();
        }
    }
}