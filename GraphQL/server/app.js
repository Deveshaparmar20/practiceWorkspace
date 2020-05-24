const express = require('express');
const schema = require('./schema/schema')
const graphqlHTTP = require('express-graphql')
const mongoose=require('mongoose');
const cors=require('cors');

const app = express();

//allow cross origin
app.use(cors());

//connect to mlabs db
mongoose.connect('mongodb+srv://dev:test123@cluster0-ajcen.mongodb.net/test?retryWrites=true&w=majority')
mongoose.connection.once('open',()=>{
    console.log('connected to db')
})

app.use('/graphql', graphqlHTTP({
    schema,
    graphiql:true
}));

app.listen(4000, () => {
    console.log('listening port 4000');
})