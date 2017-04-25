<!DOCTYPE html>
<html>

@extends('layouts.master')

@section('title')

@section('menu')
    @parent
@stop


@section('content')
   <div class="box">                  
                    
     <div class="col-lg-12 text-center">       
<meta http-equiv="refresh" content="10;/" />

<h1 class="titre"> Merci pour votre participation ! </h1>

<div class="icone"> <img src="{{URL::asset('/img/remerciement.png')}}" alt="" height="320" width="640"> </div>


	 </div>
	</div>

@stop	
</html>	

