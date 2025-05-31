# Cs-410-project-
**🌦️ WeatherApp**
WeatherApp is a simple Windows Forms application built using C# and .NET Framework 4.7.2. It allows users to fetch and display current weather information (temperature and humidity) for any city using the OpenWeatherMap API.

📋 Features
🔍 Search by city name

🌡️ Displays real-time temperature and humidity

🌐 Uses OpenWeatherMap API with live data

🖥️ Built with WinForms for a user-friendly UI

🔐 API key securely stored in App.config

🧱 Project Structure
1. App.config
Contains configuration for:

Runtime settings

API key and Base URL

Dependency version bindings for compatibility

Key Elements:

xml


<add key="key" value="Secret key" />
<add key="BaseUrl" value="https://api.openweathermap.org/data/2.5/" />
**2. Form1.cs**
Main logic for:

UI interaction

HTTP GET requests using HttpClient

JSON parsing using System.Text.Json

Displaying weather data on the form

🛠️ Technologies Used
Language: C#

Framework: .NET Framework 4.7.2

UI: Windows Forms (WinForms)

API: OpenWeatherMap

JSON Parsing: System.Text.Json

HTTP Requests: System.Net.Http

🧪 How It Works
User enters a city name.

App sends a GET request to:



https://api.openweathermap.org/data/2.5/weather?q={city}&appid={key}&units=metric
Parses JSON to extract:

main.temp → Temperature in Celsius

main.humidity → Humidity percentage

Displays results on the form.

🧩 Dependencies
These dependencies are handled by the .config binding redirects:

System.Memory

System.Threading.Tasks.Extensions

System.Runtime.CompilerServices.Unsafe

🧑‍💻 Author

GitHub:[Muhammad Asad Ullah ]

📜 License
This project is licensed under the MIT License.

**images of software**
![image](https://github.com/user-attachments/assets/d63c5497-7117-4d79-bc7b-802a669b62ff)
![image](https://github.com/user-attachments/assets/20f7b341-1ca1-4ba2-a557-5b25c45bb87c)





