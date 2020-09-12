<%@ Page Title="" Language="C#" MasterPageFile="~/Index.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="slideshow-container">

<div class="mySlides fade">
  
  <img src="Images/shopping.jpg" style="width:100%;height: 400px;">
 
</div>

<div class="mySlides fade">
 
  <img src="Images/slider-05.jpg" style="width:100%;height: 400px;">
 
</div>

<div class="mySlides fade">
 
  <img src="Images/slider2.jpg" style="width:100%;height: 400px;">
  
</div>

</div>


<div style="text-align:center">
  <span class="dot"></span> 
  <span class="dot"></span> 
  <span class="dot"></span> 
</div>
<div class="row">
  <div class="column">
    <div class="card">
      <img src="Images/4-4.jpg" alt="Avatar" style="width:100%"/>
      <p>Some Tshirts</p>
      
    </div>
  </div>

  <div class="column">
    <div class="card">
      <img src="Images/Da.jpg" alt="Avatar" style="width:100%"/>
      <p>Designs for you</p>
      
    </div>
  </div>
  
  <div class="column">
    <div class="card">
      <img src="Images/men.jpg" alt="Avatar" style="width:100%"/>
      <p>For Big Bosses Too!</p>
      
    </div>
  </div>
 
  <div class="column">
    <div class="card">
      <img src="Images/pool.jpg" alt="Avatar" style="width:100%"/>
      <p>Pool Party is on!!</p>
      
    </div>
  </div>
</div>
 <br>
  <br>
<div class="row">
  <div class="column">
    <div class="card">
      <img src="Images/hottest-sellers-men-desktop-1549260993.jpg" alt="Avatar" style="width:100%"/>
      <p>Hot Stuff</p>
      
    </div>
  </div>

  <div class="column">
    <div class="card">
      <img src="Images/arrivals.jpg" alt="Avatar" style="width:100%"/>
      <p>New Trends</p>
     
    </div>
  </div>
  
  <div class="column">
    <div class="card">
      <img src="Images/1-8.jpg" alt="Avatar" style="width:100%"/>
      <p>Tees</p>
      
    </div>
  </div>
  
  <div class="column">
    <div class="card">
      <img src="Images/2-7.jpg" alt="Avatar" style="width:100%"/>
      <p>New Jacks</p>
      
    </div>
  </div>
</div>
 <br>
  <br>
<script>
    var slideIndex = 0;
    showSlides();

    function showSlides() {
        var i;
        var slides = document.getElementsByClassName("mySlides");
        var dots = document.getElementsByClassName("dot");
        for (i = 0; i < slides.length; i++) {
            slides[i].style.display = "none";
        }
        slideIndex++;
        if (slideIndex > slides.length) { slideIndex = 1 }
        for (i = 0; i < dots.length; i++) {
            dots[i].className = dots[i].className.replace(" active", "");
        }
        slides[slideIndex - 1].style.display = "block";
        dots[slideIndex - 1].className += " active";
        setTimeout(showSlides, 2000); // Change image every 2 seconds
    }
</script>

</asp:Content>

