// mysql-express.js
const express = require('express');
const mysql = require('mysql2');
const app = express();

const connection = mysql.createConnection({
    host: 'localhost',
    user: 'root',
    password: 'root1212',
    database: 'curs_work'
});

connection.connect((err) => {
    if (err) {
        console.error('Error connecting to MySQL:', err);
        return;
    }
    console.log('Connected to MySQL database');
});

app.use((req, res, next) => {
    res.header('Access-Control-Allow-Origin', 'http://localhost:3000');
    res.header('Access-Control-Allow-Methods', 'GET, POST, PUT, DELETE');
    res.header('Access-Control-Allow-Headers', 'Content-Type');
    next();
});

app.get('/data', (req, res) => {
    connection.query('SELECT * FROM curs_work.sensor_data', (err, results) => {
        if (err) {
            console.error('Error executing query:', err);
            res.status(500).json({ error: 'Error retrieving data from database' });
            return;
        }
        res.json(results);
    });
});

app.get('/data/humidity', (req, res) => {
    connection.query('SELECT ROUND(AVG(humidity),3) AS average_humidity FROM curs_work.sensor_data', (err, results) => {
        if (err) {
            console.error('Error executing query:', err);
            res.status(500).json({ error: 'Error retrieving data from database' });
            return;
        }
        res.json(results);
    });
});

app.get('/data/temp', (req, res) => {
    connection.query('SELECT ROUND(AVG(temp),3) AS average_temp FROM curs_work.sensor_data', (err, results) => {
        if (err) {
            console.error('Error executing query:', err);
            res.status(500).json({ error: 'Error retrieving data from database' });
            return;
        }
        res.json(results);
    });
});
app.get('/data/moisture', (req, res) => {
    connection.query('SELECT ROUND(AVG(moisture),3) AS average_moisture FROM curs_work.sensor_data', (err, results) => {
        if (err) {
            console.error('Error executing query:', err);
            res.status(500).json({ error: 'Error retrieving data from database' });
            return;
        }
        res.json(results);
    });
});
app.get('/data/ph', (req, res) => {
    connection.query('SELECT ROUND(AVG(ph), 3) AS average_ph FROM curs_work.sensor_data', (err, results) => {
        if (err) {
            console.error('Error executing query:', err);
            res.status(500).json({ error: 'Error retrieving data from database' });
            return;
        }
        res.json(results);
    });
});
app.get('/data/pK', (req, res) => {
    connection.query('SELECT ROUND(AVG(pK), 3) AS average_pressurePK FROM curs_work.sensor_data', (err, results) => {
        if (err) {
            console.error('Error executing query:', err);
            res.status(500).json({ error: 'Error retrieving data from database' });
            return;
        }
        res.json(results);
    });
});
app.get('/data/pAtm', (req, res) => {
    connection.query('SELECT ROUND(AVG(pAtm), 3)  AS average_pressureAtm FROM curs_work.sensor_data', (err, results) => {
        if (err) {
            console.error('Error executing query:', err);
            res.status(500).json({ error: 'Error retrieving data from database' });
            return;
        }
        res.json(results);
    });
});
app.listen(5000, () => {
    console.log('Server is running on port 5000');
});

module.exports = app;
