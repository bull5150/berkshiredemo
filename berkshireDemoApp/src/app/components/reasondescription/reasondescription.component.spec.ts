import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ReasondescriptionComponent } from './reasondescription.component';

describe('ReasondescriptionComponent', () => {
  let component: ReasondescriptionComponent;
  let fixture: ComponentFixture<ReasondescriptionComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ReasondescriptionComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ReasondescriptionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
