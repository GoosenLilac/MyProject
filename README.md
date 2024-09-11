# WeatherForecast API
![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![Swagger](https://img.shields.io/badge/-Swagger-%23Clojure?style=for-the-badge&logo=swagger&logoColor=white)
## Введение

WeatherForecast API — это простой API, разработанный на платформе ASP.NET Core, который предоставляет данные прогноза погоды. Этот проект является демонстрацией работы с контроллерами в ASP.NET и создания API для обработки запросов о погоде.

## Необходимые условия для использования

Для того чтобы начать использовать проект, необходимо следующее:

	•	Установленная последняя версия .NET SDK (версии 7.0 и выше).
	•	Git для клонирования репозитория (необязательно, если используете zip-архив).
	•	Среда разработки (рекомендуется Visual Studio или Visual Studio Code с установленным C# расширением).

## Как установить программу

Для запуска проекта выполните следующие шаги:

1. Склонируйте репозиторий:
 
```git clone https://github.com/yourusername/weatherforecast-api.git```

2. Перейдите в директорию проекта:

 ```cd weatherforecast-api```

3. Установите зависимости и соберите проект:

  ```dotnet restore```
  ```dotnet build```

4. Запустите проект:

   ```dotnet run --project BackendApi.dll```
 


## Порядок использования

После установки и запуска API будет доступен по адресу http://localhost:5000 (или на другом порту, если задан).

•	Для получения прогноза погоды отправьте GET-запрос на /WeatherForecast:

 ```curl http://localhost:5000/WeatherForecast```

•	В ответе вы получите данные о прогнозе погоды на несколько дней:
  ```
[
  {
    "date": "2024-09-11T00:00:00",
    "temperatureC": 25,
    "temperatureF": 77,
    "summary": "Sunny"
  },
  {
    "date": "2024-09-12T00:00:00",
    "temperatureC": 22,
    "temperatureF": 72,
    "summary": "Cloudy"
  }
]
```

 
