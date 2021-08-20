class RandTitle extends React.Component {
    componentDidMount() {
        var TitleList = ["HomePage", "MyBusiness", "e-Commerce"];
        var randTitle = TitleList[Math.floor(Math.random() * TitleList.length)]
        document.title = randTitle;
    }
    render() {
        return (
            <div>Display Random Title</div>    
        )
    }
}
React.render(<RandTitle />, document.getElementById("rdt"))