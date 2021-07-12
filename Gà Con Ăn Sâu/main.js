

$(document).ready(function(){
    $(".right").click(function(){
        var a = $(".box")
        
      var div = $(".chicken");
      $("div").stop();
      div.animate({left:  (String)(a[0].offsetWidth-20)}, 3000);
  
    });
  });

$(document).ready(function(){
    $(".left").click(function(){
      var div = $(".chicken");
      $("div").stop();
      div.animate({left: '0px'}, 3000);
  
    });
  });

  $(document).ready(function(){
    $(".top").click(function(){
      var div = $(".chicken");
      $("div").stop();
      div.animate({top: '0px'}, 3000);
  
    });
  });
  $(document).ready(function(){
    $(".bot").click(function(){
      var div = $(".chicken");
      $("div").stop();
      div.animate({top: '530px'}, 3000);
  
    });
  });

  function sleep(ms) {
    return new Promise(resolve => setTimeout(resolve, ms));
  }

// function main(){
//     var chicken = document.getElementsByClassName('chicken')[0]
//     var worm = document.getElementsByClassName('worm')[0]
//     var xC = 0; // tọa độ x của con gà
//     var yC = 0; // tọa độ Y của con gà
//     var xW = 0; // Tọa độ X cảu con sâu
//     var yW = 0; // Toaj ddooj y  cảu con sâu
//     while(true){
//          sleep(2000);
//         xW = worm.offsetHeight
//         yW = worm.offsetWidth

//         xC = chicken.offsetHeight
//         yC = chicken.offsetWidth
//         console.log(xC+"   "+yC)

        


//         // if(true)
//     }
// // giwof alf lúc toán học phát huy nè
// }

function sleep(ms) {
    return new Promise(resolve => setTimeout(resolve, ms));
  }
  
async function main() {
    var chicken = document.getElementsByClassName('chicken')[0]
    var worm = document.getElementsByClassName('worm')[0]
    var d = document.getElementById('scores')

    var xC = 0; // tọa độ x của con gà
    var yC = 0; // tọa độ Y của con gà
    var xW = 0; // Tọa độ X cảu con sâu
    var yW = 0; // Toaj ddooj y  cảu con sâu
    var diem = 0;
    // Sleep in loop
    for (let i = 0; i < 1000; i++) {
   
        await sleep(100);
   

        xW = worm.offsetTop
        yW = worm.offsetLeft 

        xC = chicken.offsetTop
        yC = chicken.offsetLeft 
        if(yW>=yC-10 && yW <= yC+20 && xW>=xC-10 && xW <= xC+20){
            diem ++;
            d.textContent = diem;
            worm.style.top = Math.floor(Math.random() * 500)+"px";
            worm.style.left = Math.floor(Math.random() * 500)+"px";
        }
        
    }
  }
  main()
  
