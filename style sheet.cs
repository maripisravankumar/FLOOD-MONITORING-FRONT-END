*{
   
    box-sizing:border-box;
    font-family: Verdana, Geneva, Tahoma, sans-serif;
 }
 body{
    width:100vw;
    margin: 0 AUTO;
 }
 .header{
    width:100vw;
    min-height:150px;
    background: rgb(10,9,7);
    color:white;
    font-size: larger;
 
 }
 .header-top{
    width:100vw;
    padding:10px 20px;
    
    display: inline-block;
    font-size: smaller;
 }
 
 .logo{
    height:98px;
    width:250px;
    margin-top: 6px;
 }
 .tag{
    display: block;
    width:300px;
    margin-bottom: 10px;
    position:absolute;
    color:white;
   top:115px;
   left:0px;
 }
 
 .company-name{
    font-size: 3rem;
    width:60vw;
    display: block;
    text-align: center;
 }
 .tagline{
    font-size: 1.3rem ;
   
    width:60vw;
    text-align: center;
 }
 .company-logo .handt{
    width:60vw;
    display: block;
    padding: 9px 30px 7px 0px;
 
    float:right;
 }.company-logo{
    width: 80vw;
 }
 .company-logo span{
   
    display: block;
    text-align: center;
 }
 .logo-form{
    
    width:170px;
    float:right;
    padding-right:0px;
    height:auto;
    position:absolute;
    top:30px;
    right:0px;
 }
 .logo-form .btn{
    display: inline-block;
    padding:10px;
    background: none;
    color:white;
    border-radius:5px;
    border: transparent;
    border:2px solid transparent;
    padding-bottom:15px;
 }
 /* slider */
 
 .container{
    width:100vw;
    
    overflow:hidden;
    
 
 }
 .img-container{
    width:calc(400vw  + 20px);
    height:33vw;
    background: #ccc;
    position: relative; 
    animation-name: slide;
    overflow:hidden;
    animation-duration: 48s;
    animation-iteration-count: infinite;
    animation-timing-function: ease-out;
    animation-delay: 2s;
 }
 .slide{
    width:100vw;
    height:40vw;
    position:relative;
 }
 /*.buttons{
    width: 100vw;
    height:30px;
    background: #1f1f1f;
    padding-left:40%;
    
 }*/
 .btn1{
    display:inline-block; 
    width: 10px;
    height:10px;
    margin:10px 5px;
    background: #fff;
    border-radius:5px;
 }
 /*
 #target-1:target ~ .img-container{
    left:0px;
 }
 #target-2:target ~ .img-container{
    left:-100vw;
 }
 #target-3:target ~ .img-container{
    left:-200vw;
 }
 */
 
 /* navbar */
 .navbar{
    width:100vw;
    min-height:10px;
    background: rgb(10,9,7) ;
  
    color:white;
    
 }
 .navbar ul{
    display: flex;
 }
 .navbar ul li{
    display: inline;
    align-items: space-around;
    justify-content: center;
    flex:1;
    text-align:center ;
    list-style: none;
    padding: 0;
    margin: 0;
 }
 .navbar ul li a {
    color:white;
    text-decoration: none;
    font-size: 1.3rem;
    
 }
 
 /* spares */
 
 .item h2,.title{
    
    margin-top:20px;
    font-family: Verdana, Geneva, Tahoma, sans-serif;
    padding-left:60px;
    padding-bottom:20px;
    padding-top:20px;
    color:white;
    text-transform: uppercase;
    background:rgba(240,10,10,0.9);
    text-align:center;
    opacity: 0.6;
    border-bottom:5px solid red;
    margin-bottom:0px;
 }
 .title{
    background: rgba(13, 54, 13, 0.7);
    border-bottom:5px solid rgb(13, 54, 13);
    text-align:center;
 }
 .listitems{
    font-size: larger;
    margin-left:50px;
    padding:10px 20px;
    padding-bottom: 5px;
 
 }
 .listitems a{
    text-decoration: none;
   text-transform: capitalize;
    color:black;
 }
 .categories{
    width:80%;
    margin: 0 auto;
 }
 .categories h2,.item-content h2,.sub-title{
    
    margin-top:20px;
    font-family: Verdana, Geneva, Tahoma, sans-serif;
    padding-left:60px;
    padding-bottom:20px;
    padding-top:20px;
    color:white;
    background:rgba(10,10,240,0.9);
    opacity: 0.6;
    border-bottom:5px solid blue;
    margin-bottom:0;
 }
 .lists{
    height: auto;
    margin:0 ;
    padding:10px 20px;
    background: rgb(240,240,240);
 }
 .listitems a:hover {
    text-decoration: underline;
 
 }
 .item img{
    display: block;
    margin: 10px auto;
 }
 
 .item-1,.item-2,.item-3,.item-4,.item-5,.item-6,.item-7,.item-8{
    display:none;
 }
 #item1:target ~ .item-1{
    display: block;
 }
 
 #item2:target ~ .item-2{
    display: block;
 }
 #item3:target ~ .item-3{
    display: block;
 }
 #item4:target ~ .item-4{
    display: block;
 }
 #item5:target ~ .item-5{
    display: block;
 }
 #item6:target ~ .item-6{
    display: block;
 }
 
 #item7:target ~ .item-7{
    display: block;
 }
 #item8:target ~ .item-8{
    display: block;
 }
 .spares{
    width:50vw;
    float:left;            
 }
 .spares-content{
    width:40vw;
    float:right;
 }
 .item-21,.item-22,.item-23{
    display: none;
 }
 #item21:target ~ .item-21 , 
 #item22:target ~ .item-22 ,
 #item23:target ~ .item-23 {
   display: block;
 }
 @media(max-width:1100px){
    .spares{
       width:100vw;
        float:none;
    }
    .spares-content{
        width:100vw;
        float:none;
    }
 }
 
 /* forms */
 .signin-form,.login-form,.cform{
    width:80vw;
    margin:auto;
 
    
 }
 .form{
    margin-top:0;
    background: rgba(206, 194, 194, 0.438);
    padding:20px 50px;
 }
 .form label{
    display: block;
    width:50%;
    margin: 10px 5px;
 }
 .form input{
    box-sizing:border-box;
    width:100%;
    display: block;
    padding:20px;
    border-radius: 3px;
    border:none;
   
 }
 .form input:hover{
    background: rgba(206, 194, 194, 0.2);
    color:white;
 }
 .form input[type=text] , .form input[type = email] ,.form input[type=password],.form input[type=number],.form text area{
    border-bottom:2px solid #000;
 }
 .signin-form input[type=submit],.form input[type="submit"]{
    width:60%;
    margin:10px auto;
    padding: 15px;
    background: rgba(240,10,10,0.9);
    color:white;
    
 }
 .form input[type=submit]:hover{
    color:#fff;
    opacity: 0.6;
 }
 
 .signin-form h2,.contact-container h2{
    font-family: Verdana, Geneva, Tahoma, sans-serif;
    padding-left:60px;
    padding-bottom:20px;
    padding-top:20px;
    color:white;
    background:rgba(240,10,10,0.9);
    opacity: 0.6;
    border-bottom:5px solid red;
    margin-bottom:0;
 }
 .login-form h2{
    font-family: Verdana, Geneva, Tahoma, sans-serif;
    padding-left:60px;
    padding-bottom:20px;
    padding-top:20px;
    color:white;
    background:rgba(10,10,240,0.9);
    opacity: 0.6;
    border-bottom:5px solid blue;
    margin-bottom:0;
 }
 .login-form input[type=submit]{
    width:60%;
    margin:10px auto;
    padding: 15px;
    background: rgba(10,10,240,0.9);
    color:white;
    
 }
 .signin-form,.login-form{
    display:none;
 }
 #target1:target ~ .signin-form{
    display: block;
 }
 #target2:target ~ .login-form{
    display: block;
 }
 .sin,.lin{
    text-decoration: none;
    color:black;
    padding:10px 20px;
    background: red;
    display:inline-block;
    color:white;
 }
 .form .tab{
    width:80vw;
    margin:auto;
 }
 .tab a{
    display: inline-block;
    width:45%;
    margin:0;
 }
 /* services */
 .ser-container{
    width:100vw;
    background:rgba(60,60,60,0.1) ;
    line-height:1.5;
    min-height: 100vh;
    margin-right:0;
 }
 .ser-container .ser-title{
    text-align: center;
       padding:20px;
       border-bottom: 3px solid rgba(63, 95, 131, 0.719);
 }
 .ser-content .ser-title{
       text-align: center;
       border:0.5px solid black;
       border-bottom:3px solid black;
       box-shadow: 3px 5px 2px black;
 
 }
 .services{
       font-size: 1.3rem;
       font-weight: bold;
       margin: 0;
       display: flex;
       justify-content: space-around;
       align-items: space-around;
     
 }
 .services ul{
    flex:1;
 }
 .ser-container div{
       width:100%;
 
 }
 .ser-container div img{
       width:20vw;
       height:auto;
 }
 .ser-content{width:100vw;}
 .ser-container div:nth-child(odd) img{
    padding: 10px 20px;
    width:30vw;
    height:40vh;
    float: left;
 }
 .ser-container div:nth-child(even) img{
    padding: 10px 20px;
    width:30vw;
    height:40vh;
    float: right;
 }
 .ser-content ul{
       width:80%;
       padding-top:10px ;
       margin: auto;
       min-height:100px;
 }
 .ser-content ul li{
       line-height: 1.7;
 }
 .ser-container div:nth-child(odd) div{
  
    width:65vw;
    height:auto;
    float:right;
 }
 .ser-container div:nth-child(even) div{
 padding-left:20px;
    width:65vw;
    height:auto;
    float:left;
 }
 /* gallery */
 
 .image-container{
    width:80vw;
    margin: auto;
    min-height: 100vh;
    display: flex;
    flex-wrap: wrap;
    grid-gap:20px;
 
 }
 .images{
    width:200px;
    height: 200px;
    border:1px solid black;
    margin:10px 20px;
    position:relative;
    overflow: hidden;
   
  
 }
 .images img{
    display: block;
    width:200px;
    height:200px;
    overflow: hidden;
    
 
    
 }
 .images span{
    width:200px;
    height:200px;
    display:block;
    background: rgba(0,0,0, 0.4);
    color:white;
    text-transform: uppercase;
    padding:20px;
    padding-top: 40%;
    box-sizing: border-box;
    text-align: center;
    position:absolute;
    top:0;
    left: -200px;
  
 
 }
 .images:hover > span{
 left: 0;
 }
 
 
 
 /*.forms{
    width:90vw;
 }
 .signinform,.loginform{
    width:90%;
    background: rgba(180, 180, 180, 0.438);
    padding:20px;
    margin:30px auto;
 }
 .sform h2 ,.lform h2{
    text-align: center;
    border-bottom:3px solid red;
    background:rgba(240,10,10,0.9);
    padding: 15px;
 }
 .sform label,.sform input,.lform label,.lform input{
    display:block;
    margin:10px auto;
    padding:10px 20px;
    width:80%;
 
 }
 .sform input[type="submit"],.lform input[type="submit"]{
    width:40%;
    margin:auto;
 }*/
 /* effects */
 .logo-form .btn:hover{
    opacity: 0.6;
    border-bottom: 2px solid red;
 }
 .navbar{
    padding:20px;
 }
 .navbar ul li :hover{
    opacity: 0.7;
    padding-bottom:10px;
    font-size: 1.1rem ;
    border-bottom:2px solid red
 }
 
 /*  animation */
 @keyframes slide{
    0%{
        left:0px;
        
    }
    
    25%{
        left:-100vw;
      
    }
    
    50%{
        left:-200vw;
        
    }
    75%{
        left:-300vw;
        
    }
    100%{
        left:0px;
    }
    
 }
 /* media queries*/
 
 @media(max-width:820px){
    *{
        font-size:0.9rem;
        letter-spacing: 2px;
    }
    .handt{
        width:100vw;
        max-height: 200px;
    }
    .tagline{
        width:100%;
        font-size: 0.9rem ;
        display: block;
        padding-left: 0px;
        text-align: left;
    }
    .company-name{
        width: 100%;
        font-size:1.8rem;
        text-align: left;
        margin-left: 100px;
 
    }
    .logo-form{
        right:0px;
        bottom: 0px;
    }
  
    .handt{
        display: block;
        width:70vw;
        font-size: 20px;
   
    }
    .header-top{
        padding:0;
    }
    .company-name{
        font-size: 10px;
       
    }
    .company-logo .handt{
        width:80vw;
        margin-top:20px;
   
    }
    .navbar ul li a{
        font-size: 1.1rem;
    }
    .container{
        height:60vh;
    }
    .services,.services-content{
        width:100vw;
    }
    .ser-container div:nth-child(even) div,
    .ser-container div:nth-child(odd) div,
    .ser-container div:nth-child(odd) img,
    .ser-container div:nth-child(even) img{
        float:none;
    }
    .ser-container div:nth-child(odd) img,
    .ser-container div:nth-child(even) img{
        width:100%;
        height:auto;
    }
    .ser-container div:nth-child(even) div,
    .ser-container div:nth-child(odd) div{
        width:80vw;
        margin:auto;
    }
    .ser-content ul{
        width:100%;
    }
    .form,.signin-form,.login-form{
        width:100vw;
        margin:0;
    }
 }
 
 @media(max-width:1050px){
    .tagline{
        font-size: 0.9rem ;
    }
    .company-name{
        
        font-size:1rem;
 
    }
    .tag{
        top:105px;
        height:30px;
    }
    .logo{
        padding-left:20px;
        padding-top:20px;
    }
    .handt{
        width:100vw;
        max-height: 200px;
    }
    .tagline{
        width:100%;
        font-size: 0.9rem ;
        display: block;
        padding-left: 0px;
        text-align: center;
    }
    .company-name{
        width: 100%;
        font-size:1.8rem;
        text-align: center;
        margin-left: 100px;
 
 
    }
    .company-logo .handt div {
        text-align: left;
        display: inline;
    }
    .navbar ul{
       flex-direction: column;
    }
    .navbar ul li{
        justify-content: flex-start;
        text-align: left;
       
        padding:10px 0 10px 40px;
    }
 
    .logo-form{
        margin-right: -20px;
    }
    .services,services-content{
        width:100vw;
        margin:0;
    }
    .image-container{
        width:60vw;
 
    }
