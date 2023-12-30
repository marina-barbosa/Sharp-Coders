const express = require('express');
const jwt = require('jsonwebtoken');
const cors = require('cors');

const app = express();

app.use(express.json());
app.use(cors()); // seguranca dos navegadores, 

// app.get('/', (req, res) => {

//     let token = jwt.sign({ 'nome': 'Marina' }, 'segredo', {expiresIn:'1h'});

//     res.status(200).json({ 'token': token });
// })

app.post('/', (req, res) => {

    const user = req.body.usuario;
    const senha = req.body.senha;

    if (user == 'admin' && senha == 'admin') {
        let token = jwt.sign({ 'nome': 'Marina' }, 'segredo', { expiresIn: '5m' });

        res.status(200).json({ 'token': token });
    } else {
        res.status(400).json({ 'erro': 'usuario uo senha incorreto' });
    }


})

app.get('/', (req, res) => {

    const bearer = req.headers['authorization'];

    if (!bearer) {
        return res.status(401).json({ 'erro': 'informe o token' });
    }

    const token = bearer.split(' ');

    jwt.verify(tokenEnviado[1], 'segredo', (erro) => {
        if (erro) {
            return res.status(401).json({ 'erro': erro });
        }
    })

    return res.status(200).json({ 'mensagem': 'token valido' });
})

// npx nodemon index.js

app.listen(3333, () => {
    console.log('server ON')
})