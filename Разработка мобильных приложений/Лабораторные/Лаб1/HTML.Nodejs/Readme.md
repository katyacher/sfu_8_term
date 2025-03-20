Инструкция по запуску

    Установите зависимости:
    npm install express cors mongoose dotenv
    
    Создайте файл .env:
    MONGODB_URI=mongodb://localhost:27017/notes-app
PORT=3000

Запустите сервер:
node server.js

    Получите API ключи:

    OpenWeatherMap (ссылка) https://openweathermap.org/api

    Google Maps JavaScript API https://developers.google.com/maps/documentation/javascript?hl=ru 

    Вставьте полученные ключи в HTML:
    const API_KEY = 'ВАШ_КЛЮЧ_OPENWEATHERMAP';
<script src="https://maps.googleapis.com/maps/api/js?key=ВАШ_КЛЮЧ_GOOGLE_MAPS"></script>


Особенности реализации

    Адаптивный дизайн с CSS Grid

    Обработка ошибок в API запросах

    Автоматическое сохранение времени создания записи

    Поддержка CORS для кросс-доменных запросов

    Простая расширяемая архитектура

Для полноценной работы необходимо:

    Установить MongoDB

    Зарегистрировать API ключи

    Настроить безопасность (HTTPS, валидация ввода)

    Добавить загрузку сохраненных записей (при необходимости)
