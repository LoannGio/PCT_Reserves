<!DOCTYPE html>
<html>

@extends('layouts.master')

@section('title')

@section('menu')
    @parent
@stop


@section('content')

<meta http-equiv="refresh" content="10;/" />

<h1 class="titre"> Merci pour votre participation ! </h1>

<div class="icone"> <img src="{{URL::asset('/images/remerciement.png')}}" alt="profile Pic" height="200" width="200"> </div>



@stop	
</html>	

