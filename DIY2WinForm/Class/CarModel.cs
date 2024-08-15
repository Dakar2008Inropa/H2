using Newtonsoft.Json;

namespace DIY2WinForm.Class
{
    public class CarModel
    {
        public string Id { get; set; }
        public string CarMakerId { get; set; }
        public CarMaker Maker { get; set; }
        public string Model { get; set; }
        public int ProductionYear { get; set; }
        public string Color { get; set; }


        private static string ApplicationFilesPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "DakarApps", "CarDatabase");

        private static string CarModelFileName = "CarModels.json";

        private static string CarModelFilePath = Path.Combine(ApplicationFilesPath, CarModelFileName);


        public CarModel()
        {
            Id = Guid.NewGuid().ToString("N");
        }

        public static List<CarModel> LoadCarModelData()
        {
            if (File.Exists(CarModelFilePath))
            {
                return JsonConvert.DeserializeObject<List<CarModel>>(File.ReadAllText(CarModelFilePath));
            }
            else
            {
                return new List<CarModel>();
            }
        }

        public static void SaveCarModelData(List<CarModel> carModelList)
        {
            if (!Directory.Exists(ApplicationFilesPath))
            {
                Directory.CreateDirectory(ApplicationFilesPath);
            }

            File.WriteAllText(CarModelFilePath, JsonConvert.SerializeObject(carModelList));
        }
    }
}