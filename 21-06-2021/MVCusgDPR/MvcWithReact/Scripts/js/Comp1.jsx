var Comp1 = React.createClass({
    render: function () {
        return (
            <div>
                <h1 style={{ backgroundColor: "red" }}>Multi Comp1 </h1>
            </div>
            )
    }
})

React.render(<Comp1 />, document.getElementById("c1"));