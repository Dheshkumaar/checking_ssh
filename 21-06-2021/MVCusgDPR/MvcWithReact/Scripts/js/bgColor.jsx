var styles = {
    color: "grey",
    backgroundColor: "skyblue",
    fontSize: 50
}
class Stile extends React.Component {
    render() {
        return (
            <div>
                <h2 style={ styles }>styling the Page</h2>
            </div>           
        )            
    }
}
React.render(<Stile />, document.getElementById("style"));