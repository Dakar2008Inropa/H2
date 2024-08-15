using Newtonsoft.Json;

namespace DIY2WinForm.Class
{
    public class CarMaker
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }


        private static string ApplicationFilesPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "DakarApps", "CarDatabase");

        private static string CarMakerFileName = "CarMaker.json";

        private static string CarMakerFilePath = Path.Combine(ApplicationFilesPath, CarMakerFileName);


        public CarMaker()
        {
            Id = Guid.NewGuid().ToString("N");
        }

        public static List<CarMaker> LoadCarMakerData()
        {
            if (File.Exists(CarMakerFilePath))
            {
                return JsonConvert.DeserializeObject<List<CarMaker>>(File.ReadAllText(CarMakerFilePath));
            }
            else
            {
                return new List<CarMaker>();
            }
        }

        public static void SaveCarMakerData(List<CarMaker> carMakerList)
        {
            if (!Directory.Exists(ApplicationFilesPath))
            {
                Directory.CreateDirectory(ApplicationFilesPath);
            }

            File.WriteAllText(CarMakerFilePath, JsonConvert.SerializeObject(carMakerList));
        }
    }
}