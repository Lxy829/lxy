//轮播图片
var i = 0;
var timer;
//将图片名称放置数组
var img = ["1.jpg", "2.jpg", "3.jpg", "4.jpg", "5.jpg", "6.jpg"];
document.getElementById("right").onclick = function () {
    rotate();
}
function rotate() {
    i++;
    //获取img元素
    var photo = document.getElementById("photo");
    //当i为最后一张图片，重新赋值为第一张
    if (i == 5 + 1) {
        i = 0;
    }
    //通过设置图片路径切换图片
    photo.src = "img/" + img[i];
    var span = document.getElementById("dot").getElementsByTagName("span");
    dot_style(span[i]);
}
//点击左按钮
document.getElementById("left").onclick = function () {
    i--;
    var photo = document.getElementById("photo");
    if (i == -1) {
        i = 5;
    }
    photo.src = "img/" + img[i];
    var span = document.getElementById("dot").getElementsByTagName("span");
    dot_style(span[i]);
}
timer = setInterval(function () { rotate(); }, 3000);    //计时器自动轮换图片
function dotonclick(index) {
    i = index;
    var photo = document.getElementById("photo");
    photo.src = "img/" + img[index];//点击进行传参，按照传参设置路径
    var span = document.getElementById("dot").getElementsByTagName("span");
    dot_style(span[i]);

}
//圆点样式
function dot_style(value) {
    var span = document.getElementById("dot").getElementsByTagName("span");
    for (var j = 0; j < span.length; j++) {
        if (value == span[j]) {
            value.className = 'current';
        }
        else {
            span[j].className = 'dspan';
        }
    }
}
document.getElementById("carousel").onmouseover = function () {
    clearInterval(timer);
}
document.getElementById("carousel").onmouseout = function () {
    timer = setInterval(function () { rotate(); }, 3000);
}
//悬浮导航
window.onscroll = function () {
    var navigation = document.getElementById('navigation');
    var fixation= document.getElementById('fixation');
    var fixation_one= document.getElementById('fixation_one');
    var fixation_two = document.getElementById('fixation_two');
    var scrollTop = document.body.scrollTop || (document.documentElement && document.documentElement.scrollTop);
    if (scrollTop <= 100) {     
        navigation.style.position = 'relative';
        document.getElementById("font").style.visibility = "visible";
        navigation.style.backgroundImage = "linear-gradient(to bottom , rgba(0, 0, 0, .50),rgba(0, 0, 0, 0))";
        document.getElementById("input").style.background = "white";   
        document.getElementById("img_2").src = "img/icon_3.png";
        document.getElementById("img_3").src = "img/icon_4.png";
        document.getElementById("font_two").style.color = "white";
        document.getElementById("font_three").style.color = "white";
        document.getElementById("font_five").style.color = "white";
        document.getElementById("all").style.backgroundImage='url(img/quan1.png)'
        document.getElementById("all").onmouseover=function(){
            document.getElementById("all").style.backgroundImage='url(img/quan2.png)'
        }
        document.getElementById("all").onmouseout=function(){
            document.getElementById("all").style.backgroundImage='url(img/quan1.png)'
        }
        
       
    }
    if (scrollTop > 100) {
        navigation.style.position = 'fixed';
        navigation.style.position.top = '-1';
        navigation.style.display = 'block';
        navigation.style.backgroundImage = "linear-gradient(to bottom , rgba(255, 255, 255),rgba(255, 255, 255))";
        document.getElementById("font").style.visibility = "hidden";
        document.getElementById("input").style.backgroundColor = "#ECECEC";
        document.getElementById("img_2").src = "img/icon_3_2.png";
        document.getElementById("img_3").src = "img/icon_4_2.png";
        document.getElementById("font_two").style.color = "#5A5A5A";
        document.getElementById("font_three").style.color = "#5A5A5A";
        document.getElementById("font_five").style.color = "#5A5A5A";
         document.getElementById("all").style.backgroundImage='url(img/quan2.png)';
         document.getElementById("all").onmouseout=function(){
         document.getElementById("all").style.backgroundImage='url(img/quan2.png)'
        }
       
    }
    if (scrollTop >=300){
        fixation_one.style.display="block";
        fixation_two.style.display="block";
        fixation.classList.add("position");
    }
    if (scrollTop <300){
        fixation_one.style.display="none";
        fixation_two.style.display="none";
        fixation.className="fixation";
    }
}
    //切换
     var div=document.getElementById("op").getElementsByTagName("div");
     var tion=document.getElementById("tion").getElementsByTagName("span");
    function switchover(num){
        for(var i=0;i<=div.length;i++){
            if(i==num){
                div[i].style.display="block";
                tion[i].className="style_sift";                
            }
            else{
                div[i].style.display="none";
                tion[i].className="style_sift_2";
            }
        }
    }
    var div_2=document.getElementById("op_2").getElementsByTagName("div");
    var op_head=document.getElementById("op_head").getElementsByTagName("span");
    function switchover_2(num_2){
        for(var i=0;i<=div_2.length;i++){
            if(i==num_2){
                div_2[i].style.display="block";
                op_head[i].className="style_sift";
                
            }
            else{
                div_2[i].style.display="none";
                op_head[i].className="style_sift_2";
            }
        }
    }
    var pbody=document.getElementById("pbody").getElementsByTagName("div");
    var phead=document.getElementById("phead").getElementsByTagName("span");
    function evaluates(count)
    {
        for(var j=0;j<=pbody.length;j++){
            if(j==count){              
                pbody[j].style.display="block";
                phead[j].className="big";
                phead[j].style.opacity="1";
                phead[j].style.border="2px #DADADA solid";
            }
            else{
                pbody[j].style.display="none";
                phead[j].className="";
                phead[j].style.opacity="0.5";
                phead[j].style.border="0px #DADADA solid";
            }
        }
    }
    function alltion(){
        var all_block=document.getElementById("all_block");
            all_block.style.display="block";
    }
    function all_show(ve){
        var all_div=document.getElementById("all_label_1").getElementsByTagName("div");
        var all_img=document.getElementById("all_label_2").getElementsByTagName("img");
        for(var i=0;i<=all_img.length;i++){
            if(i==ve){
                all_img[i].style.display="block";
                all_div[i].style.background="#EDF5F5";
                all_div[i].style.color="#00BE6E";

            }
            else{
                all_img[i].style.display="none";
                all_div[i].style.background="white";
                all_div[i].style.color="black";
            }
        }
    }
    function all_none(){
        var all_block=document.getElementById("all_block");
        all_block.style.display="none";
    }
    function recommend(recommend_value){
      var  reimg=document.getElementById("recommend_three").getElementsByTagName("img");
      var  respan=document.getElementById("recommend_two").getElementsByTagName("span")
      for(var i=0;i<reimg.length;i++){
          if(i==recommend_value){
            reimg[i].style.display="block";
            respan[i].style.color="#888888";            
          }
          else{
           reimg[i].style.display="none";
           respan[i].style.color="#CBCACA";
          }
      }
    }
    var count_1=1;
    function act(){
         var actblock=document.getElementById("recommend");
         var acta=document.getElementById("acta");
         actblock.style.display="block";
         acta.innerHTML="∨";
         if(count_1%2==0){
            actblock.style.display="none";
            acta.innerHTML="∧";
         }
         count_1=count_1+1;
         
    }