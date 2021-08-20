class Datecomp extends React.Component {
    componentDidMount() {
        var str = "MyReactPage";
        document.title = str;
    }
    render() {
        var dtime = new Date();
        var curddate = dtime.toDateString();
        var curtime = dtime.getHours() + ":" + dtime.getMinutes() + " :" + dtime.getSeconds();
        return (
            <div>
                <h3>{curddate}</h3>
                <h1>{curtime}</h1>
                <title>My Title</title>
            </div>
        )
    }
}
React.render(<Datecomp />, document.getElementById("dt"));