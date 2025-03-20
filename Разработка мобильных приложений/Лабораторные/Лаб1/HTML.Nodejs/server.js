require('dotenv').config();
const express = require('express');
const cors = require('cors');
const mongoose = require('mongoose');

const app = express();
app.use(cors());
app.use(express.json());

// Подключение MongoDB
mongoose.connect(process.env.MONGODB_URI, {
    useNewUrlParser: true,
    useUnifiedTopology: true
});

// Модель для текста
const TextEntry = mongoose.model('TextEntry', {
    title: String,
    content: String,
    createdAt: { type: Date, default: Date.now }
});

// API для сохранения
app.post('/api/save-text', async (req, res) => {
    try {
        const newEntry = new TextEntry(req.body);
        await newEntry.save();
        res.status(201).send({ success: true });
    } catch (error) {
        res.status(500).send({ error: 'Ошибка базы данных' });
    }
});

const PORT = process.env.PORT || 3000;
app.listen(PORT, () => {
    console.log(`Сервер запущен на порту ${PORT}`);
});
