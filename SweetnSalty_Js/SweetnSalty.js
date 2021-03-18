
// //Start of Sweet And Salty

let sweet = 3;
let salty = 5;
let sweetNsalty = "";
function SweetOrSalty(x, y, sweetNsalty) {
    for(i = 0; i <= 990; i +=10){
        for(j = 1; j <= 10; j++){
            if((i+j)%x == 0 && (i+j)%y == 0) {
                sweetNsalty += "Sweet n' Salty";
            }else if ((i+j)%x == 0) {
                sweetNsalty += "Sweet ";
            }else if((i+j)%y == 0) {
                sweetNsalty += "Salty ";
            }else{
                sweetNsalty += ((i+j) + " ");
            }
         
        }
        sweetNsalty += "\n";
    }
    return sweetNsalty;
}
let z = SweetOrSalty(sweet, salty, sweetNsalty);
console.log(z);