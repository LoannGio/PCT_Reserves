<?php

namespace App\Http\Controllers;
use Illuminate\Http\Request;
use App\Http\Requests;
use App\Http\Controllers\Controller;

class WelcomeController extends Controller
{
    public function index()
    {
        return view('welcome');
    }
    public function sondage($n)
    {
    	return view('sondage')->with('n',$n);
    }
    public function oeuvres($n)
    {
    	return view('oeuvres')->with('n',$n);	
    }
    public function oeuvre($n)
    {
    	return view('oeuvre')->with('n',$n);	
    }
    public function voter($n)
    {
    	return view('voter')->with('n',$n);	
    }
}