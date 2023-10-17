import { Component, ElementRef, OnInit, ViewChild } from "@angular/core";
import { EletronicPointService } from "../services/eletronic-point.service";
import { EletronicPoint } from "src/app/models/eletronicPoint";

@Component({
    selector: 'details',
    templateUrl: './details.component.html'
  })

export class DetailsComponent implements OnInit {

    @ViewChild('canvas', {static: true}) myCanvas! : ElementRef;

    public eletronicPoint: EletronicPoint[] = [];

    constructor(private eletronicPointService: EletronicPointService) {
    }

    ngOnInit(): void {
        this.createCanvas();
        this.getAll();
    }

    getAll(){
      this.eletronicPointService.get('eletronicPoint').subscribe(
        (eletronicPoints:EletronicPoint[]) =>
        {
          this.eletronicPoint = eletronicPoints;
          console.table(this.eletronicPoint);
        }
      );
    }

    createCanvas(){
        const canvas: HTMLCanvasElement = this.myCanvas.nativeElement;
        const context = canvas.getContext('2d');
    
        if(context){
          context.beginPath();
          context.arc(75, 75, 50, 0, Math.PI * 2, true); // Círculo exterior
          context.moveTo(110, 75);
          context.arc(75, 75, 35, 0, Math.PI, false);  // Boca (sentido horário)
          context.moveTo(65, 65);
          context.arc(60, 65, 5, 0, Math.PI * 2, true);  // Olho esquerdo
          context.moveTo(95, 65);
          context.arc(90, 65, 5, 0, Math.PI * 2, true);  // Olho direito
          context.stroke();
        }
    }
}
