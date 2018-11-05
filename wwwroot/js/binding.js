//object creation
let robot = {
    action: 'jump',
    movement : function(){
        console.log(console.action)
    }
}

let button = document.getElementById('buttonPlacement')

button.addEventListener(
    'click',
    robot.movement.bind(robot)
)
