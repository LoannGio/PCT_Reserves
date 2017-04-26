<!DOCTYPE html>
<html lang="fr">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="">
    <meta name="author" content="">

    <link href="{{ asset('css/style.css') }}" rel="stylesheet">
    <link rel="stylesheet" type="text/css" href="https://cdn.datatables.net/1.10.13/css/jquery.dataTables.min.css">
    <link href="{{ asset('css/bootstrap.min.css') }}" rel="stylesheet">
    <link href="{{ asset('css/business-casual.css') }}" rel="stylesheet">

    <script src="//code.jquery.com/jquery-1.12.4.js"></script>
    <script type="text/javascript" src="{!! asset('js/bootstrap.min.js') !!}"></script>

    <script type="text/javascript" src="{!! asset('js/jquery.dataTables.min.js') !!}"></script>
    <script type="text/javascript" src="{!! asset('js/img.js') !!}"></script>

    <link href="https://fonts.googleapis.com/css?family=Open+Sans:300italic,400italic,600italic,700italic,800italic,400,300,600,700,800" rel="stylesheet" type="text/css">
    <link href="https://fonts.googleapis.com/css?family=Josefin+Slab:100,300,400,600,700,100italic,300italic,400italic,600italic,700italic" rel="stylesheet" type="text/css">
    <script>
    $('.carousel').carousel({
        interval: 5000//changes the speed
    })
    </script>

    <script>$(document).ready(function() {
        $('#example').DataTable();
    } );</script>

    <title>MBA BORDEAUX  @yield('title')</title>
</head>
<body>
    @section('menu')
    <div class="brand">
        Musée des Beaux-Arts de Bordeaux
        <div class="box box1">
                
                    <div id="carousel-example-generic" class="carousel slide">
                        <!-- Indicators -->
                        <ol class="carousel-indicators hidden-xs">
                            <li data-target="#carousel-example-generic" data-slide-to="0" class="active"></li>
                            <li data-target="#carousel-example-generic" data-slide-to="1"></li>
                            <li data-target="#carousel-example-generic" data-slide-to="2"></li>
                        </ol>

                        <!-- Wrapper for slides -->
                        <div class="carousel-inner">
                            <div class="item active">
                                <img class="img-responsive img-full" src="{{URL::asset('img/slide-1.jpg')}}" alt="" >
                            </div>
                            <div class="item">
                                <img class="img-responsive img-full" src="{{URL::asset('img/slide-2.jpg')}}" alt="" >
                            </div>
                            <div class="item">
                                <img class="img-responsive img-full" src="{{URL::asset('img/slide-3.jpg')}}" alt="" >
                            </div>
                        </div>

                        <!-- Controls -->
                        <a class="left carousel-control" href="#carousel-example-generic" data-slide="prev">
                            <span class="icon-prev"></span>
                        </a>
                        <a class="right carousel-control" href="#carousel-example-generic" data-slide="next">
                            <span class="icon-next"></span>
                        </a>
                    </div>
           
        </div>
    </div>

       
    <!-- Navigation -->
    <nav class="navbar navbar-default" role="navigation">
        <div class="container">

            <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                <ul class="nav navbar-nav">
                    <li><a href="/">Accueil</a></li>
                    <li><a href="http://www.musba-bordeaux.fr/">Notre site</a></li>
                </ul>
            </div>
            <!-- /.navbar-collapse -->
        </div>
        <!-- /.container -->
    </nav>
    <div class="address-bar"><marquee direction="left"> * * * Merci pour votre visite sur notre espace de vote * * * </marquee></div>
    <div class="container">

        <div class="row">
            
            @show
            @yield('content')       
        </div>
        <br> <br> <br>
    </div>
    
    <footer>
        <div class="container">

            <div class="row">
                <div class="col-lg-12 text-center" >
                    <p>Copyright © 2017 BORDEAUX. Tous droits réservés.</p>
                </div>
            </div>
        </div>
    </footer>


</body>

</html>


