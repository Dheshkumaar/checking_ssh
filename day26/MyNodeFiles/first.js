const http = require('http');

const server = http.createServer((req,res)=>{
    const url = req.url;
    const method = req.method;
    console.log(url+" "+method);
    if(url === "/service" && method === "GET")
    {
        res.write("<h1>Service</h1>");
        res.write("<form method='POST'><input type='text' name='txtUN'><input type='text' name ='txtPass'><button type='submit'>Send</button>");
        return res.end();
    }
    if(url === "/service" && method === "POST")
    {
        let userMessage =[];
        let message = "Invalid username or password";
        req.on('data',(mydata)=>{
            userMessage.push(mydata);
        })
        req.on('end',()=>{
            const parsedData = Buffer.concat(userMessage).toString();
            const user = parsedData.split('&');
            let username = user[0].split('=')[1];
            let password = user[1].split('=')[1];
            console.log(username+" "+password);
            if(username == "ramu" && password=="1234")
                message = "Welcome User";
            console.log(message);
        })
        res.write("<h1>Post Done</h1>");
        return res.end();
    }
    if(url === "/"){
        res.write("<h1>Home</h1>");
        return res.end();
    }
    if(url === "/about"){
        res.write("<h1>About</h1>");
        return res.end();
    }
    res.write("<h1>No such Page....</h1>");
    res.end();
    
});

server.listen(2500);
console.log("Server started");
// function print(){
//     console.log("line in side the async");
// }
// print();
// setTimeout(()=>{
//     console.log("welcome");
// },2000);
// console.log("Line after async");