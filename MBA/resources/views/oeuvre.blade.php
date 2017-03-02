<!DOCTYPE html>
<html>
<link href="{{ asset('/css/style.css') }}" rel="stylesheet">
@extends('layouts.master')

@section('title')

@section('menu')
    @parent
@stop


@section('content')

<?php

$oeuvre = DB::table('OeuvreParSondage')->whereid($n)->first();
echo"<br>";
echo "<a href='../voter/$oeuvre->id'><CENTER>Voter</CENTER></a>";
echo"<br>";
echo "<img src='{$oeuvre->url_img}' alt='profile Pic' height='200' width='200'>";
echo"<br>";
echo $oeuvre->titre, '<br>';
echo $oeuvre->auteur, '<br>';
echo $oeuvre->description, '<br>';

?>

@stop	
</html>
