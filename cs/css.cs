 *{
        margin: 0;
    }
 .container{
    border:1px solid white;
    height:2700px;
    width:1260px;
    margin:auto;
    }
.navigation{
    position: relative;
    top:-2px;
    border:0px solid black;
    height: 70px;
    line-height: 90px;
    background: linear-gradient(to bottom , rgba(0, 0, 0, .50),rgba(0, 0, 0, 0));
    z-index:3;
      }
.carousel{
    width:1260;
    height:450px;
    overflow: hidden;
    margin-top:-70px;
    }
.carousel:hover .right{
        display:block;
        }
        .carousel:hover .left{
        display:block;
        }

       .right{
            display: block;
            border: 0px solid black;
            width:45px;
            height:140px;
            background-image: url(../img/lun.png);
            background-position: -5px 0px;
            position: absolute;
            z-index: 1;
            margin-top:-300px;
            display: none;
     
        }
        .right:hover{
            background-image: url(../img/lun.png);
            background-position: 47px 0px;
        }
        .left{
            display: inline-block;
            border: 0px solid black;
            width:45px;
            height:140px;
            background-image: url(../img/lun.png);
            background-position: -56px 0px;
            position: absolute;
            z-index: 1;
            margin-top:-300px;
            margin-left: 1214px;
            display: none;
           
        }
        .left:hover{
            background-image: url(../img/lun.png);
            background-position: 98px 0px;
        }
        .dspan{
            color:#999999;
            font-size: 20px;
        }
        .dot{
            border:1px solid black;
            width:100px;
            margin:auto;
            margin-top:-50px;
            cursor: pointer;
        }
        .current{
            color: #10C55B;
            font-size: 20px;
        }
        .navigation span:first-of-type{
            margin-left: 40px;
        }
        .qb_t{
            margin-left:50px;
            position: relative;
            top:-20px;
            left:-20px;
        }
        .qb_z{
            margin-left:0px;
            color: white;
            position: relative;
            top:-25px;
            left:-20px;
        }
        .navigation span:nth-of-type(2) input{
           width: 500px;
           height:44px;
           border:0 solid white;
           border-radius:5px;
           opacity: 0.5;
           position: relative;
           top:-10px;
           margin-left:25px;
        }
        .navigation span:nth-of-type(3){
            display:inline-block;
            width:90px;      
            height:48px;
            background-image: url(../img/捕获.png);
            position: relative;
            top:8px;
            left:-20px;
            background-size:90px;
        }
        .navigation span:nth-of-type(4){
            position: relative;
           top:-8px;
           margin-left:70px;
        }
       
        .navigation span:nth-of-type(5){
           position: relative;
           top:-8px;
           margin-left:25px;
        }
        .navigation span:nth-of-type(6){
           display:inline-block;
           width:23px;      
           height:20px;
           background-image: url(../img/headerimg_v2.png);
           background-position: 90px 50px;
           position: relative;
           top:-8px;
           margin-left:25px;
        }
        .navigation span:nth-of-type(7){
           padding:5px;
           width:90px;      
           height:20px;
           color: #00BE6E;
           border:#00BE6E 1px solid;
           border-radius: 3px;
           font-size: 14px;
           position: relative;
           top:-11px;
           margin-left:50px;
        }
        .navigation span:nth-of-type(8){
         margin-right: 10px;
         display: inline-block;
         font-size: 12px;
         position: relative;
         top:-65px;
         margin-left:300px;
        }
        .navigation span:nth-of-type(8) a{
            color: white;
            margin-right:10px;
            cursor: pointer;
        }
        .navigation span:nth-of-type(8) a:hover{
            color:#00BE6E;

        }
        .navigation span:nth-of-type(9) a{
            color:white;
            cursor: pointer;
            font-size: 12px;
            position: relative;
            left:130px;
            top:-80px;
            margin-left:5px;
        }
        .navigation span:nth-of-type(9) a:hover{
            color: #00BE6E;
        }
        .sift span{
            margin-right:20px;
            cursor: pointer;

             
        }
        .sift{    
            width:1220px;
            margin:auto;
            border:0px solid black;
            margin-top:10px;
        }
  .style_sift
            {
            color:#FDA233;
            display:inline-block;
            height:30px;
            border-bottom:2px #FDA233 solid;
            }
  .style_sift_2{
            color:#666666;
  }
        .option_cutrren{
            display: block;
        }
        .option{
            display: none;
        }
        .itemize{
            color: #666666;
            display: inline-block;
            background-color:#F5F5F5;
            width: 225px;
            height:45px;
            line-height: 45px;
            border-radius: 10px;
            padding-left: 10px;
            margin-left:10px;
            cursor: pointer;
        }
        .tem{
            color: #3C3C3C;
            font-weight: bold;
            cursor: pointer;
        }
        .itemize a{
            margin-left: 2px;
        }
        .itema:hover{
            color:#10C55B;
        }
        .classify{
            width:1240px;
            border: 0px solid black;
            margin:auto;
            margin-top:10px;
        }
        .tem2{
            cursor: pointer;
            color: #666666;
            display: inline-block;
        }
        .tem2 a{
           margin-left: 50px;
        }
        .tem3{
            color: #666666;
            display: inline-block;
            background-color:#F5F5F5;
            padding:10px 20px 10px 20px; 
            position:absolute;
            margin-top:-60px;
            margin-left:50px;
            border-radius: 10px;
            cursor: pointer;
        }
        .tem3 a{
            margin-left: 5px;
        }
        .hr{
            width:0.2px;
            height:80px;
            position: absolute;
            background-color:  #3C3C3C;
            margin-top:-30px;
            margin-left:770px;
        }
        .more{
            position: absolute;
            margin-left: 150px;
            margin-top:-10px;
        }
        .sift_head{
            border:0px solid black;
            width:1220px;
            margin:auto;
            margin-top:30px;
        }
        .sift_head span:first-of-type{
            color: #10C55B;
            font-size: 20px;
        }
        .sift_head span:nth-of-type(2){
            font-size: 20px;
            color: #666666;
        }
        .sift_head span:nth-of-type(3){
            font-size: 20px;
            color: #666666;
            font-weight: bolder;
        }
        .sift_head span{
            margin-right:20px;
 
        }
            .btn {
            display: inline-block;
            height: 30px;
            line-height: 30px;
            color: #595959;
            border: 1px solid #E5E5E5;
            width: 110px;
            text-align: center;
            border-radius: 5px;
        }

        .btn:hover {
            background-color: #EDFFF4;
            color: #00BE6E;
            border: 1px solid #00BE6E;
        }

        .zcolor {
            color: #666666;
        }

        .cover {
            display: inline-block;
            width: 285px;
            height: 379px;
            background: rgba(0, 0, 0, .50);
            position: absolute;
            display: none;
            left: 0px;
            top: 0px;
        }

        .y1 {
            position: absolute;
            left: 310px;
        }

        .y2 {
            position: absolute;
            left: 620px;
        }

        .y3 {
            position: absolute;
            left: 925px;
        }

        .y4 {
            position: absolute;
            top: 400px;
        }

        .y5 {
            position: absolute;
            top: 400px;
        }

        .y6 {
            position: absolute;
            top: 400px;
        }

        .y7 {
            position: absolute;
            top: 400px;
        }

        .imgese:hover .cover {
            display: block;
        }

        .dw {
            position: relative;
            top: 0px;
        }

        .zai {
            display: inline-block;
            background-color: #00BE6E;
            width: 150px;
            height: 40px;
            text-align: center;
            line-height: 40px;
            position: relative;
            top: 160px;
            left: 70px;
            z-index: 2;
            color: white;
        }

        .zai:hover {
            background-color: #06C38A;
        }
        .p_head span{
            display: inline-block;
            width: 50px;
            height:50px;
            border:0px solid white;
            border-radius: 100%;
            opacity: 0.5;
        }
        .p_y{
            font-size: 20px;
            text-align: center;
            color: #666666;
            margin-top: 20px;
        }
        .p_head{
            text-align: center;
            margin-top:30px;
        }
        .p_t{
            display: none;
        }
        .p_body div{
            text-align: center;
        }
        .big{
            transform:scale(1.2);
        }
        .p_body{
            height:150px;
            border:0px black solid;
            margin-top:10px;
        }
                .b_tu {
            margin-top: 20px;
            text-align: center;
        }

        .b_tu span {
            margin-left: 100px;
        }

        .bottom {
            background-color: #F5F5F5;
            height: 300px;
            width: 1260px;
            margin: auto;
            margin-left: -20px;
            margin-top: 30px;
            position: relative;
            top: 0px;
            border: 0px black solid;
        }

        .bottom span:nth-of-type(1) {
            color: #888888;
            position: absolute;
            top: 50px;
            left: 30px;
        }

        .bottom span:nth-of-type(2) {
            position: absolute;
            top: 0px;
            left: 230px;
            color: #888888;
            top: 50px;
        }

        .bottom span:nth-of-type(3) {
            position: absolute;
            top: 0px;
            left: 430px;
            color: #888888;
            top: 50px;
        }

        .bottom a {
            display: block;
            font-size: 12px;
            margin-top: 5px;
        }

        .consult {
            border: 0px black solid;
            width: 300px;
            height: 120px;
            margin-left: 800px;
            position: relative;
            top: 50px;
        }

        .consult div {
            margin-top: 10px;
        }

        .bottom_t {
            position: relative;
            top: 7px;
        }

        .bottom_z {
            color: #888888;
        }

        .bottom_btn {
            border: 0px solid black;
            width: 120px;
            height: 40px;
            background: #11C85D;
            border-radius: 5px;
            text-align: center;
            line-height: 40px;
        }

        .bottom_btn:hover {
            background-color: #06C38A;
        }

        .banquan {
            color: #999999;
            text-align: center;
        }

        .banquan label {
            margin-left: 10px;
            font-size: 12px;
        }
         .fixation {
            width: 50px;
            height: 440px;
            position: fixed;
            z-index: 5;
            left: 1212px;
            top: 260px;
        }

        .fixation div {
            width: 50px;
            height: 70px;
            border: 1px #ECECEC solid;

        }

        .fixation div:nth-of-type(1) {
            background-image: url(../img/u1.png);
            background-position: -2px;
            background-repeat: no-repeat;
            background-size: 55px;
        }

        .fixation div:nth-of-type(1):hover {
            background-image: url(../img/u1_2.png);
        }

        .fixation div:nth-of-type(2) {
            background-image: url(../img/u2.png);
            background-position: -2px;
            background-repeat: no-repeat;
            background-size: 55px;
            margin-top: -3px;
        }

        .fixation div:nth-of-type(2):hover {
            background-image: url(../img/u2_2.png);
        }

        .fixation div:nth-of-type(2):hover .q_d {
            display: block;

        }

        .fixation div:nth-of-type(3) {
            background-image: url(../img/u3.png);
            background-position: -2px;
            background-repeat: no-repeat;
            background-size: 55px;
        }

        .fixation div:nth-of-type(3):hover {
            background-image: url(../img/u3_2.png);
        }

        .fixation div:nth-of-type(4) {
            background-image: url(../img/u4.png);
            background-position: -2px;
            background-repeat: no-repeat;
            background-size: 55px;
        }

        .fixation div:nth-of-type(4):hover {
            background-image: url(../img/u4_2.jpg);
        }

        .fixation div:nth-of-type(5) {
            background-image: url(../img/u5.png);
            background-position: -2px;
            background-repeat: no-repeat;
            background-size: 55px;
        }

        .fixation div:nth-of-type(5):hover {
            background-image: url(../img/u5_2.jpg);
        }

        .fixation div:nth-of-type(6) {
            background-image: url(../img/u6.png);
            background-position: -2px;
            background-repeat: no-repeat;
            background-size: 55px;
            margin-top: 1px;
            display: none;
        }

        .fixation div:nth-of-type(7) {
            background-image: url(../img/u7.png);
            background-position: -2px;
            background-repeat: no-repeat;
            background-size: 55px;
            margin-top: 1px;
            display: none;
        }

        .fixation div:nth-of-type(7):hover {
            background-image: url(../img/u7_2.png);
        }

        .fixation div:nth-of-type(6):hover {
            background-image: url(../img/u6_2.png);
        }

        .q_d {
            position: relative;
            left: -180px;
            display: none;
        }

        .all {
            border: 0px black solid;
            display: inline-block;
            width: 110px;
            height: 40px;
            position: relative;
            top: 10px;
            left: 15px;
            background-image: url(../img/quan1.png);
            background-size: 90px;
            background-repeat: no-repeat;
        }

        .all_block {
            position: absolute;
            top: 45px;
            border: 0px solid black;
            height: 378px;
            width: 800px;
            background-color: white;
            z-index: 6;
            /* left:159px; */
            display: none;
        }

        .all:hover {
            background-image: url(../img/quan2.png);
        }

        .all_label_1 div {
            border: 0px solid black;
            height: 50px;
            margin-left: -39px;
            line-height: 45px;
            text-indent: 10px;
            font-size: 14px;
        }

        /* .all_label_1 div:hover{
            background: #EDF5F5;
            color: #00BE6E;
        } */

        .all_label_1 {
            background-color: white;
            display: inline-block;
            width: 170px;
            height: 360px;
            position: relative;
            top: -20px;
        }

        .all_label_2 {
            background-color: white;
            display: inline-block;
            width: 550px;
            height: 360px;
            position: relative;
            top: 0px;
            left: -4px;
        }

        .all_tu {
            display: none;
        }

        .all:hover .all_block {
            display: block;
        }

        .position {
            top: 100px;
        }

        .bg {
            background-image: url(../img/quan2.png);
        }

        .bg2 {
            background-image: url(../img/quan1.png);
        }
        .recommend{
            border: 0px solid black;
            width: 1200px;
            margin:auto;
            display: none;
            margin-top:20px;
        }
        .recommend_t{
            display: none;
        }
        .recommend_two
        {
            font-size: 13px;
            color:#CBCACA;
        }
        .act{
            border: 0px solid black;
            width: 1200px;
            margin:auto;
            font-size: 13px;
            color: #CBCACA;
        }