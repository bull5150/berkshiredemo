import { Component, OnInit, Input } from '@angular/core';
import { reasons_description } from 'src/app/models/reasonsModels';
import { ReasonsServiceService } from 'src/app/services/reasons-service.service';

@Component({
  selector: 'reasondescription',
  templateUrl: './reasondescription.component.html',
  styleUrls: ['./reasondescription.component.css']
})
export class ReasondescriptionComponent implements OnInit {

  @Input() reasonID: number;
  public reasonDescription: reasons_description;

  constructor(private reasonService: ReasonsServiceService) { }

  ngOnInit() {
    this.reasonDescription = new reasons_description();
    this.displayDescription();
  }
  displayDescription(): void{
    this.reasonService.getDescription(this.reasonID+1).subscribe(response=>{
      this.reasonDescription = response;
    });
  }
}
